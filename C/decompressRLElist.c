#include <stdio.h>
#include <stdlib.h>
int* decompressRLElist(int* nums, int numsSize, int* returnSize){
    int i, j, k=0, size=0; 
    for(i=0; i< numsSize/2;i++)
        size+=nums[2*i];
    *returnSize = size;
    int * decompressed = (int*) malloc(size*sizeof(int));
    for(i=0; i< numsSize/2;i++)
        for(j=0; j<nums[2*i]; j++)
            decompressed[k++]=nums[2*i+1];
    return decompressed;
}
int main(){
    int nums[6] = {2,5,1,3,4,7};
    int nums2[4] = {1,2,3,4};

    int * retSize;
    int * declist =decompressRLElist(nums, 6, retSize);
    int i;
    for(i=0; i<6; i++)
        printf("%d ",nums[i]);
    printf("\n");
    for(i=0; i<*retSize; i++)
        printf("%d ",declist[i]);
    printf("\n");
    free(declist);
    int *declist2 =decompressRLElist(nums2, 4, retSize);
    for(i=0; i<4; i++)
        printf("%d ",nums2[i]);
    printf("\n");
    for(i=0; i<*retSize; i++)
        printf("%d ",declist2[i]);
    printf("\n");
    free(declist2);
}