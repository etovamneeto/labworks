#include <stdio.h>
#include <mpi.h>


int main(int argc, char **argv){
  
  int nproc, rank;
  MPI_Comm comm = MPI_COMM_WORLD;
  MPI_Init(&argc, &argv);
    MPI_Comm_size(comm,&nproc);
    MPI_Comm_rank(comm, &rank);
    printf("num = %d rank = %d\n", nproc, rank);
  MPI_Finalize();
  
  return 0;
}