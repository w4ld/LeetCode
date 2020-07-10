def reverseString(s):
    """
    Do not return anything, modify s in-place instead.
    """
    j=len(s)-1
    for i in range((j+1)//2):
        t=s[i]
        s[i]=s[j]
        s[j]=t
        j-=1

hello = ["h","e","l","l","o"]
test = ["t", "e","s","t"]
print(hello)
reverseString(hello)
print(hello)
print(test)
reverseString(test)
print(test)
o = ["o"]
reverseString(o)
o.append("e")
reverseString(o)
print(o)