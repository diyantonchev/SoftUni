#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#define BUFFER_SIZE 4096
#define MESSAGE_SIZE 40

void kill(const char*);

void swap(char*, char*, size_t);

int main(int argc, char** argv) 
{
   if(argc < 3)
       kill("Usage:<src-path> <dest-path>");
    
    FILE *srcFile = fopen(argv[1], "r"); 
    if(!srcFile)
    {   
       kill(argv[1]);
    }
        
    FILE *destFile = fopen(argv[2], "a");
    
    while(!feof(srcFile) && !ferror(srcFile) && !ferror(destFile))
    {
        char buffer[BUFFER_SIZE];
        size_t readBytes = fread(buffer, 1, BUFFER_SIZE, srcFile);
        size_t length = strlen(buffer);
        char chunk[length];
        swap(buffer, chunk, length);
        chunk[length] = '\0';
        fwrite(chunk, 1, BUFFER_SIZE, destFile);        
    }
    
    fclose(srcFile);
    fclose(destFile);
    
    printf("Success!");
    return (EXIT_SUCCESS);
}

void kill(const char* msg)
{
    if(errno)
    {
        perror(msg);
    }
    else
    {
        fprintf(stderr,"%s\n", msg);
    }
    
    exit(1);
}

void swap(char* src, char* dest, size_t length)
{    
    int mid = length / 2;
    int i, j = 0;
    for (i = mid; i < length; i++, j++) 
    {
        dest[j] = src[i];
    }

    for (i = 0; i < mid; i++, j++) 
    {
        dest[j] = src[i];
    }
}
