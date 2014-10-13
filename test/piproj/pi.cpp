#include <stdio.h>
#include <mpi.h>
#include <math.h>

double function(double x){
      
    return 4.0/(1+x*x);
  
}

int main(int argc, char **argv){
 
  int np, rank, N = 1000;
  double pi;
  MPI_Comm comm = MPI_COMM_WORLD;
  
  if(argc > 1){
    
      sscanf(argv[1], "%d", &N);
      if(N < 1)
	N = 1000;
      
  }
  
  MPI_Init(&argc, &argv);
  
    double t = MPI_Wtime();
  
    MPI_Comm_size(comm, &np);
    MPI_Comm_rank(comm, &rank);
    
    double h = 1.0/(double)N; //шаг
    double summ = 0;//сумма
  
    for(int i = rank; i < N; i+=np){
    
      double x = (i+0.5)*h;
      summ += function(x);
      
    }
    
    summ*= h;
    
    MPI_Reduce(&summ, &pi, 1, MPI_DOUBLE, MPI_SUM, 0, comm);
    
    if(rank == 0){ 
      printf("Pi = %12.9f\n", pi);
      printf("Time= %15.8g\n", MPI_Wtime()-t);
    }
    
    MPI_Finalize();
      
  return 0;
  
}