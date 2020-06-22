def compareVersion(version1, version2):
    """
    :type version1: str
    :type version2: str
    :rtype: int
    """
    vInts1 = version1.split('.')
    vIntLen1 = len(vInts1)
    vInts2 = version2.split('.')
    vIntLen2 = len(vInts2)
    vLen = vIntLen1 if vIntLen1 > vIntLen2 else vIntLen2
    order = 10**vLen
    vv1 = 0
    vv2 = 0
    for i in range(vLen):
        v1 = int(vInts1[i]) if vIntLen1 > i else 0
        v2 = int(vInts2[i]) if vIntLen2 > i else 0
        vv1 += order * v1
        vv2 += order * v2
        order /= 10
    if (vv1 > vv2):
        return 1
    elif (vv1 < vv2):
        return -1
    else:
        return 0

def compareVersionTest():

    print( 1 == compareVersion("1.0", "0.1"))
    print( 0 == compareVersion("0.1.0", "0.1"))
    print( -1 == compareVersion("0.0.1", "0.1"))
    print( 0 == compareVersion("1.1", "1.1"))
    print( 1 == compareVersion("1.1", "1"))
    print( 0 == compareVersion("1.0", "1"))
compareVersionTest()