//Problem URL: https://www.hackerrank.com/challenges/game-of-thrones/problem

static string gameOfThrones(string s) {
    int[] noOfLetters = new int[26];
    int noOfOddTotals = 0;

    for(int i = 0; i < s.Length; i++){
        int index = (int)s[i] - (int)'a';
        noOfLetters[index]++;
    }

    for(int i = 0; i < 26; i++){
        noOfOddTotals += noOfLetters[i] % 2;
    }

    return (noOfOddTotals > 1) ? "NO" : "YES";
}