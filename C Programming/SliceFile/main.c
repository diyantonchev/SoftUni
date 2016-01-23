#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#define BUFFER_SIZE 4096
#define PART_NAME_LENGTH 20

void kill(const char*);

void slice(const char*, const char*, size_t);

void assemble(const char*, const char*, size_t);

int main(int argc, char** argv) 
{  
   //if(argc < 4)
     //   kill("Usage: ./prog <src-path> <dest-path> <parts count>");

    //char* srcPath = argv[1];
    //char* destPath = argv[2]; 
    //har* remeinder;
    long partsCount = 5;
    //= strtol(argv[3], &remeinder, 10);

    //slice(srcPath, destPath, partsCount);  
   
    
    const char* partsPathFormat = "Parts/part-%lu.avi"; 
    char* assemblyDestPath = "Assembled/assembly.avi"; 
        
    assemble(assemblyDestPath, partsPathFormat, partsCount);
   
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

void slice(const char* srcPath, const char* destPath, size_t parts)
{
    FILE *srcFile = fopen(srcPath,"r");
    if(!srcFile)
        kill("Error open source file");
    
    fseek(srcFile, 0, SEEK_END);
    long long position = ftell(srcFile);
    fseek(srcFile, 0, SEEK_SET);
    
    long long partSize = (position / parts) + 1;
    char buffer[BUFFER_SIZE];
    size_t i;
    for (i = 0; i < parts; i++) 
    {
        char name[PART_NAME_LENGTH];
        sprintf(name, "%s/part-%lu.avi", destPath, i + 1);
        size_t nameLength = strlen(name);
        name[nameLength] = '\0';
        
        FILE *currentDestFile = fopen(name,"w");
        if(!currentDestFile)
            kill("Error open destination file");
        
        size_t writtenBytes = 0;
        char buffer[BUFFER_SIZE];
        while(writtenBytes <= partSize && !feof(srcFile))
        {
            size_t readBytes = fread(buffer, 1, BUFFER_SIZE, srcFile);
            fwrite(buffer, 1, readBytes, currentDestFile);
            writtenBytes += readBytes;
        }  
        
        fclose(currentDestFile);
    }
    
    fclose(srcFile);
    printf("Done!\n");
}

void assemble(const char* assemblyDestPath, const char* partsPathFormat,  size_t partsCount)
{
    FILE *assembledFile = fopen(assemblyDestPath, "a");
    if(!assembledFile)
        kill("Error open assembly file.");    
    
    size_t i;
    for (i = 0; i < partsCount; i++) 
    {       
        char currentPartPath[PART_NAME_LENGTH];
        sprintf(currentPartPath, partsPathFormat, i + 1);
       
        FILE *currentPartFile = fopen(currentPartPath, "r");
        if(!currentPartFile)
            kill("Error open part file.");
  
        char buffer[BUFFER_SIZE];
        while(!feof(currentPartFile) && !ferror(currentPartFile))
        {
            size_t readBytes = fread(buffer, 1, BUFFER_SIZE, currentPartFile);
            fwrite(buffer, 1, BUFFER_SIZE, assembledFile);
        }
        
        fclose(currentPartFile);
    }  
    
     fclose(assembledFile);
     printf("Done!\n");
}