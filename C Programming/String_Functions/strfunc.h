#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#define INITIAL_BUFFER_SIZE 50

int word_count(char*, char);

size_t strlength(char*);

int strsearch(char*, char*);

char* substr(char*, size_t, size_t);

char* read_line();

char* string_join(char**, size_t, char*);

int contains(char**, size_t, char*);