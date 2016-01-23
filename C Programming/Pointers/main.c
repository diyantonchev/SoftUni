
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#define BUFFER_SIZE 255

struct Client 
{
    char name[BUFFER_SIZE];
    int age;
    long double account_balance;
};

void sort_clients(struct Client clients[], int clientsCount, int (*comparator)(struct Client c1, struct Client c2));

int name_comparator(struct Client c1, struct Client c2);

int age_comparator(struct Client c1, struct Client c2);

int balance_comparator(struct Client c1, struct Client c2);

void print_struct_array(struct Client clients[], int clientsCount);

char* read_line();

int main(int argc, char** argv) 
{       
   /*struct Client client1;
    struct Client client2;
    struct Client client3;
    struct Client client4;
    
    strcpy(client1.name, "Sasho\0");
    client1.age = 20;
    client1.account_balance = 243135251.5635;
    strcpy(client2.name, "Pesho\0");
    client2.age = 42;
    client2.account_balance = 10003034.12343;
    strcpy(client3.name, "Gosho\0");
    client3.age = 50;
    client3.account_balance = 5614390.91531;
    strcpy(client4.name, "Acho\0");
    client4.age = 23;
    client4.account_balance = 64588166.2858;
    
    struct Client clients[] = { client1, client2, client3, client4 };
    int clientsCount = sizeof(clients) / sizeof(clients[0]);
    
    printf("Sorted by name:\n");
    sort_clients(clients, clientsCount, &name_comparator);
    print_struct_array(clients, clientsCount);
    printf("Sorted by age:\n");
    sort_clients(clients, clientsCount,&age_comparator); 
    print_struct_array(clients, clientsCount);
    printf("Sorted by account balance:\n");        
    sort_clients(clients, clientsCount, &balance_comparator);
    print_struct_array(clients, clientsCount); */
    
    char* string = read_line();
    printf("%s", string);
    free(string);
    
    return 0;
}

char* read_line()
{
    size_t initialSize =  20;
    char* line = malloc(initialSize);
    if(!line)
    {
        exit(1);
    }
    
    int index = 0;
    char currentChar;
    scanf("%c", &currentChar);
    while(currentChar != '\n')
    {
        if(index >= initialSize)
        {
            char* resizedLine = realloc(line, initialSize * 2);
            if(!resizedLine)
            {
                printf("Not enough memory");
                exit(1);
            }
            
            line = resizedLine;
            initialSize * 2;
        }
        
        *(line + index) = currentChar;
        index++;
        scanf("%c", &currentChar);
    }
    
    *(line + index) = '\0';
    return line;    
}

void print_struct_array(struct Client clients[], int clientsCount)
{
    int i;
    for (i = 0; i < clientsCount; i++) 
    {
        printf("Client name: %s\nAge:%d\nAccount balance: %Lf\n\n", clients[i].name, clients[i].age, clients[i].account_balance);
    }
}

int name_comparator(struct Client c1, struct Client c2)
{
    return strcmp(c1.name, c2.name) > 0;
}

int age_comparator(struct Client c1, struct Client c2)
{
    return c1.age > c2.age;
}

int balance_comparator(struct Client c1, struct Client c2)
{
    long double result = c1.account_balance - c2.account_balance;
    return result > 0.0000001;
}

void sort_clients(struct Client clients[], int clientsCount, int (*comparator)(struct Client c1, struct Client c2))
{
    int has_swapped = 1;
    while (has_swapped)
    {
        has_swapped = 0;
        int i;
        for (i = 0; i < clientsCount - 1; i++) 
        {    
            struct Client c1 = clients[i];
            struct Client c2 = clients[i + 1];
            if(comparator(c1, c2))
            {
                clients[i] = c2;
                clients[i + 1] = c1;
                has_swapped = 1;
            }
        }
    }
}