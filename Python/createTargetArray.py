def createTargetArray(nums, index):
    """
    :type nums: List[int]
    :type index: List[int]
    :rtype: List[int]
    """
    retList = list()
    for i in range(len(index)):
        retList.insert(index[i], nums[i])
    return retList

#testing
nums = [0,1,2,3,4]
index = [0,1,2,2,1]
output = [0,4,1,3,2]
print(createTargetArray(nums, index))
print(output)
nums2 = [1,2,3,4,0]
index2 = [0,1,2,3,0]
output2 = [0,1,2,3,4]
print(createTargetArray(nums2, index2))
print(output2)

nums3 = [1]
index3 = [0]
output3 = [1]
print(createTargetArray(nums3, index3))
print(output3)
