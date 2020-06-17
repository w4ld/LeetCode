def findNumbers( nums):
    """
    :type nums: List[int]
    :rtype: int
    """
    ret = 0

    for i in range(len(nums)):
        x = 1;
        nums[i] = nums[i] // 10
        while nums[i] > 0:
            x+=1
            nums[i] = nums[i] // 10
        if x % 2 == 0:
            ret+=1
    
    return ret
    
nums = [2,5,12,3,4,7]
ret = findNumbers(nums)
if(ret==1):
    print("Pass")
else:
    print("Fail")
nums2 = [2333,5,12,3,4444,7]
ret2 = findNumbers(nums2)
if(ret2==3):
    print("Pass")
else:
    print("Fail")