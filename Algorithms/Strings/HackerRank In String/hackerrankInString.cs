//Problem URL: https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem

static string hackerrankInString(string s) {
    string toMatch = "hackerrank";

    for(int i = 0, j = 0; i < s.Length; i++){
        if(s[i] == toMatch[j]){
            //Console.WriteLine("Found " + toMatch[j] + " at index: " + i);
            j++;
        }

        if(j == toMatch.Length)
            return "YES";
    }

    return "NO";   
}
