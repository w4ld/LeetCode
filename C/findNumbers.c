#include <stdlib.h>
#include <stdio.h>
int findNumbers(int* nums, int numsSize){
  int ret = 0;
    for(int i=0;i<numsSize;i++)
    {
        int x = 1;
        while ((nums[i] /= 10) > 0)
            x++;
        if (x % 2 == 0)
            ret++;
    }
    return ret;
}
int main(){
    int nums[6] = {2,5,12,3,4,7};
    int ret = findNumbers(nums, 6);
    if(ret==1)
        printf("Pass\n");
    else
        printf("Fail\n");
    int nums2[6] = {2333,5,12,3,4444,7};
    int ret2 = findNumbers(nums2, 6);
    if(ret2==3)
        printf("Pass\n");
    else
        printf("Fail\n");
}