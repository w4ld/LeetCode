#include <stdlib.h>
#include <stdio.h>

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* shuffle(int* nums, int numsSize, int n, int* returnSize){
    printf("Numssize: %d\n", numsSize);
   int *retptr = (int*) malloc((numsSize+1) * sizeof(int));
   *returnSize = numsSize;
   int i;
   for(i=0; i<n; ++i){
      //printf("%d, %d, ",nums[i], nums[i+n]);
    //   memcpy(&retptr[2*i],nums[i], sizeof(int));
    //   memcpy(&retptr[2*i+1],nums[i+n], sizeof(int));
        retptr[2*i] = nums[i];
        retptr[2*i+1] = nums[i+n];
   }
    //return nums;
   return retptr;
}
int main(){
    int nums[6] = {2,5,1,3,4,7};
    int * retSize;
    int * shuffled = shuffle(nums, 6, 3, retSize);
    int i;
    for(i=0; i<6; i++)
        printf("%d ",nums[i]);
    printf("\n");
    for(i=0; i<6; i++)
        printf("%d ",shuffled[i]);
    printf("\n");
    free(shuffled);
    //shuffle
}

