def decompressRLElist(nums):
    """
    :type nums: List[int]
    :rtype: List[int]
    """
    retList = list()
    for i in range(0, len(nums), 2):
        for j in range(0, nums[i]):
            retList.append(nums[i+1])
    return retList

nums = [2,5,1,3,4,7]
declist = decompressRLElist(nums)
print(nums)
print(declist)
nums2 = [1,2,3,4]
declist2 = decompressRLElist(nums2)
print(nums2)
print(declist2)