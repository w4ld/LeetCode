def hasAlternatingBits(n):
        """
        :type n: int
        :rtype: bool
        """
        binn = toBinaryString(n)
        for i in range(len(binn)-1):
            if binn[i] == binn[i+1]:
                return False    
        return True
def toBinaryString(n):
    retstr=""
    while(n>0):
        retstr= str(n%2) + retstr
        n//=2 #dont forget pythons noninteger division default...
    return retstr
