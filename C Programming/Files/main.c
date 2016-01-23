
#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#define BUFFER_SIZE 4096

void kill(const char* msg);

int main(int argc, char** argv)
{
    FILE *file = fopen("program.c","r");
    if(!file)
        kill(NULL);
    
    char* line = NULL;
    size_t size = 0;
    int lineCounter = 0;
    while(!feof(file))
    {
       size_t length = getline(&line, &size, file);        
       
       printf("%-3d%s",lineCounter, line);
           
       lineCounter++;
    }   
    
    free(line);
    fclose(file);
    
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
        fprintf(stderr, "%s\n", msg);
    }
    
    exit(1);
}