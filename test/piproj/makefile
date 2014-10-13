#makefile for testproject

CPP = mpicxx
CFLAGS = -c -O2
LFLAGS = -lm
OBJS = pi.o

result:$(OBJS)
	$(CPP) -o result $(OBJS) $(LFLAGS)
pi.o:pi.cpp
	$(CPP) $(CFLAGS) pi.cpp


