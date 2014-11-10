#include <stdio.h>
#include <math.h>
#include <time.h>
#include <mpi.h>
#include <stdlib.h>

double randFunc(double min, double max){
 
  return(double)(rand())/RAND_MAX*(max-min)+min;
  
}

int main(int argc, char **argv){
  

  //clock_t start = clock();
  
  int N = 0;//число точек
  int Ncrc = 0;
  double x = 0, y = 0, Pi = 0;
  int radius = 1;
  

  
  if(argc > 1){ 
    
      sscanf(argv[1], "%d", &N);
      if(N < 1)
	N = 1000;      
  }
  
  
  MPI_Init (&argc, &argv);
  
  int nproc, rank;
  int summ = 0;
  MPI_Comm comm = MPI_COMM_WORLD;
  double t = MPI_Wtime();
  
  MPI_Comm_size(comm, &nproc);
  MPI_Comm_rank(comm, &rank);
  
  
  for (int i = rank; i<N; i+=nproc){
   
    x = randFunc(-(double)radius, (double)radius);
    y = randFunc(-(double)radius, (double)radius);
  
    if((x*x+y*y)<=(radius))
      Ncrc+=1;
   
  }

  printf("Nproc = %d\n", nproc);
  
  MPI_Reduce(&Ncrc, &summ, 1, MPI_DOUBLE, MPI_SUM, 0, comm);
  Pi = 4.0*summ/N;
/*  
  clock_t stop = clock();
  
  printf("\n");
  if(!N){    
    printf("Не введено число испытаний N\n");  
  }else{    
    printf("	Число PI = %12.9f\n", Pi);
  }
*/  

  printf("\n");
  //printf("	Время выполнения программы = %f (сек)\n", (double)(stop-start)/CLOCKS_PER_SEC);
      if(rank == 0){ 
      printf("Pi = %12.9f\n", Pi);
      printf("Time= %15.8g\n", MPI_Wtime()-t);
    }
  printf("\n");
  
  MPI_Finalize();
       
  return 0;
}
