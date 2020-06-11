
def shuffle( nums, n):
        """
        :type nums: List[int]
        :type n: int
        :rtype: List[int]
        """
        retlist=list()
        for i in range(n):
            retlist.append(nums[2*i])
            retlist.append(nums[2*i+1])
        return retlist
def shuffleTest():
    nums = [2,5,1,3,4,7]
    print (shuffle(nums, 3))


