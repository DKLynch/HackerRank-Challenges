//Problem URL: https://www.hackerrank.com/challenges/ctci-making-anagrams/problem

static int makeAnagram(string a, string b) {
    int[] aLetters = new int[26];
    int[] bLetters = new int[26];

    foreach(char c in a){
        int charIndex = (int)(c % 32) - 1;
        aLetters[charIndex]++;
    }

    foreach(char c in b){
        int charIndex = (int)(c % 32) - 1;
        bLetters[charIndex]++;
    }

    int totalDiffs = 0;
    for(int i = 0; i < 26; i++){
        if(aLetters[i] != bLetters[i])
            totalDiffs += Math.Abs(aLetters[i] - bLetters[i]);
    }

    return totalDiffs;
}
