#makefile for this project

#компилятор
CPP = g++
#Опции компилятора
CFALGS = -c -O2 -fopenmp
#Опции линкера
LFLAGS = -lm -lgomp
#Список объектных файлов
OBJS = laba3.o

#Компиляция и сборка
#цель:список
result: $(OBJS)
	$(CPP) -o result $(OBJS) $(LFLAGS)
main.o: main.cpp
	$(CPP) $(CFALGS) laba3.cpp
