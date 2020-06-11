
def numberOfSteps (num): #takes a num and returns number of steps
    #if num even divide by 2 
    #if num odd subtract 1
    """
    :type num: int
    :rtype: int
    """
    ctr = 0
    while num > 0:
        ctr+=1
        if num % 2 == 0 :
            num /= 2
        else:
            num -= 1
    return ctr
def numberOfStepsTest():    
    print(numberOfSteps(14))
    print(numberOfSteps(14) == 6)
    print(numberOfSteps(8))
    print(numberOfSteps(8) == 4) 
    print(numberOfSteps(123)) 
    print(numberOfSteps(123)==12) 

