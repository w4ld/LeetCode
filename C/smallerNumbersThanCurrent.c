#include <stdlib.h>
#include <stdio.h>
int* smallerNumbersThanCurrent(int* nums, int numsSize, int* returnSize){
    int i, j, c;
    int *retArr = (int *)(malloc(numsSize*sizeof(int)));
    *returnSize = numsSize;
    for(i = 0; i < numsSize; i++){
        c=0;
        for(j=0; j < numsSize; j++){
            if(nums[j]<nums[i] && j!=i){
               ++c; 
            }
        }
        retArr[i] = c;
    }
    return retArr;
}
void printIntArray(int* arr, int arrSize){
    int i;
    printf("[ ");
    for(i=0; i<arrSize; i++){
        if(i==0)
            printf("%d", arr[i]);
        else
            printf(", %d", arr[i]);
    }
    printf(" ]\n");
}
int compareIntArrays(int* arrA, int arrASize, int* arrB, int arrBSize){
    if(arrASize != arrBSize)
        return 0;
    int i;
    for(i=0; i < arrASize; i++){
        if(arrA[i] != arrB[i]){
            return 0;
        }
    }
    return 1;
}
void test(int *in, int insz, int *out, int outsz){
    int* retsz;
    int* ret = smallerNumbersThanCurrent(in,insz,retsz);
    if(compareIntArrays(ret, *retsz, out, outsz)==1)
        printf("PASS\n");
    else
        printf("FAIL\n");
    free(ret);
}
int main(){
    //case1
    int t1[5] = {8, 1, 2, 2, 3};
    int o1[5] = {4, 0, 1, 1, 3};
    //case2
    int t2[4] = {6, 5, 4, 8};
    int o2[4] = {2, 1, 0, 3};
    //case3
    int t3[4] = {7, 7, 7, 7};
    int o3[4] = {0, 0, 0, 0};
   
    //case4
    int t4[7] = {7, 7, 7, 7, 78, 7, 7};
    int o4[7] = {0, 0, 0, 0, 6, 0, 0};

    test(t1, 5, o1, 5);
    test(t2, 4, o2, 4);
    test(t3, 4, o3, 4);
    test(t4, 7, o4, 7);
    
}
