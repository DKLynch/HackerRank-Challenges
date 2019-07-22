//Problem URL: https://www.hackerrank.com/challenges/alternating-characters/problem

static int alternatingCharacters(string s) {
    int nonAlternating = 0;

    for(int i = 0; i < s.Length - 1; i++){
        if(s[i] == s[i + 1])
            nonAlternating++;
    }

    return nonAlternating;
}
