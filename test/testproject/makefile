#makefile for testproject

CPP = g++
CFLAGS = -c -O2
LFLAGS = -lm
OBJS = testfile.o

result:$(OBJS)
	$(CPP) -o result $(OBJS) $(LFLAGS)
testfile.o:testfile.cpp
	$(CPP) $(CFLAGS) testfile.cpp


