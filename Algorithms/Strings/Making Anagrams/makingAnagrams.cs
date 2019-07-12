//Problem URL: https://www.hackerrank.com/challenges/making-anagrams/problem

static int makingAnagrams(string s1, string s2) {
    int noDeletions = 0;
    int[] noLetters1 = new int[26];
    int[] noLetters2 = new int[26];

    for(int i = 0; i < s1.Length; i++){
        int charIndex = (int)(s1[i] % 32) - 1;
        noLetters1[charIndex]++;
    }

    for(int i = 0; i < s2.Length; i++){
        int charIndex = (int)(s2[i] % 32) - 1;
        noLetters2[charIndex]++;
    }

    for(int i = 0; i < 26; i++)
        noDeletions += Math.Abs(noLetters1[i] - noLetters2[i]);

    return noDeletions;
}
