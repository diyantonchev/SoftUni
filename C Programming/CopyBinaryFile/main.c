#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#define BUFFER_SIZE 4096

void kill(const char*);

void copy(const char*, const char*);

int main(int argc, char** argv)
{
    if(argc < 3)
        kill("Usage: ./prog <src-file> <dest-file>");
    
    copy(argv[1], argv[2]);
    
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

void copy(const char* srcPath, const char* destPath)
{
    FILE *sourceFile = fopen(srcPath,"r");
    if(!sourceFile)
        kill(NULL);
    
    FILE *destFile = fopen(destPath, "w");
    if(!destFile)
        kill(NULL);
    
    char buffer[BUFFER_SIZE];
    while(!feof(sourceFile) && !ferror(sourceFile) && !ferror(destFile))
    {
        size_t readedBytes = fread(buffer, 1, BUFFER_SIZE, sourceFile);
        size_t witedBytes = fwrite(buffer, 1, BUFFER_SIZE, destFile);
    }

    fclose(sourceFile);
    fclose(destFile);
}