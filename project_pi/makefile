#makefile for this project

#компилятор
CPP = g++
#Опции компилятора
CFALGS = -c -O2
#Опции линкера
LFLAGS = -lm
#Список объектных файлов
OBJS = main.o

#Компиляция и сборка
#цель:список
result: $(OBJS)
	$(CPP) -o result $(OBJS) $(LFLAGS)
main.o: main.cpp
	$(CPP) $(CFALGS) main.cpp
