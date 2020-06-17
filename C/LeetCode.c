#include <stdlib.h>
#include <stdio.h>
int numberOfSteps (int num){
int ctr = 0;
    while (num > 0){
        ctr++;
        if(num % 2 == 0 )
            num /=2;
        else 
            --num;
    }
    return ctr;
}
int main(){
    printf(numberOfSteps(14));
    printf(numberOfSteps(14) == 6);
    printf(numberOfSteps(8));
    printf(numberOfSteps(8) == 4); 
    printf(numberOfSteps(123));
    printf(numberOfSteps(123)==12);
}