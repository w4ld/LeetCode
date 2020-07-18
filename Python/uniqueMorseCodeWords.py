from mock import MagicMock
def uniqueMorseRepresentations( words ):
    """
    :type words: List[str]
    :rtype: int
    """
    morse_words = set() #set because they want distinct count
    morse_alphabet = [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
    for word in words:
        morse_word=""
        for letter in word:
            morse_word+=morse_alphabet[ord(letter)-97]
        morse_words.add(morse_word)
    return len(morse_words)


def uniqueMorseRepresentationsTesting():
    words = ["gin", "zen", "gig", "msg"]
    print(2==uniqueMorseRepresentations(words))
    words = ["hello", "world", "a", "bee"]
    print(4==uniqueMorseRepresentations(words))

'''Notes
    The length of words will be at most 100.
    Each words[i] will have length in range [1, 12].
    words[i] will only consist of lowercase letters.
'''
uniqueMorseRepresentationsTesting()