#include <stdio.h>
#include <math.h>
#include <time.h>
#include <stdlib.h>

double randFunc(double min, double max){
 
  return(double)(rand())/RAND_MAX*(max-min)+min;
  
}

int main(int argc, char **argv){

  clock_t start = clock();
  
  int N = 0;//число точек
  int Ncrc = 0;
  double x = 0, y = 0, Pi = 0;
  int radius = 1;
  
  if(argc > 1){ 
    
      sscanf(argv[1], "%d", &N);
      if(N < 1)
	N = 1000;      
  }
  
  
  
  for (int i = 0; i<N; i++){
   
    x = randFunc(-(double)radius, (double)radius);
    y = randFunc(-(double)radius, (double)radius);
  
    if((x*x+y*y)<=(radius))
      Ncrc+=1;
  }
  
  Pi = 4.0*Ncrc/N;
  
  clock_t stop = clock();
  
  printf("\n");
  if(!N){    
    printf("Не введено число испытаний N\n");  
  }else{    
    printf("	Число PI = %12.9f\n", Pi);
  }
  
  printf("\n");
  printf("	Время выполнения программы = %f (сек)\n", (double)(stop-start)/CLOCKS_PER_SEC);
  printf("\n");
       
  return 0;
}