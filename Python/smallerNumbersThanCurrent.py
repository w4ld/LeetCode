def smallerNumbersThanCurrent( nums):
    """
    :type nums: List[int]
    :rtype: List[int]
    """
    smaller = list()
    numLen = len(nums)
    for n in range(numLen):
        count=0
        for m in range(numLen):
            if nums[m] < nums[n] and m!=n:
                count+=1
        smaller.append(count)
    return smaller

t1 = [8,1,2,2,3]
t2 = [6,5,4,8]
t3 = [7,7,7,7]
print(t1)
print(smallerNumbersThanCurrent(t1))
print(t2)
print(smallerNumbersThanCurrent(t2))
print(t3)
print(smallerNumbersThanCurrent(t3))