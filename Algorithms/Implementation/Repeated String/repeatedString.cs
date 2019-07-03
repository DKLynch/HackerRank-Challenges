//Problem URL: https://www.hackerrank.com/challenges/repeated-string/problem

static long repeatedString(string s, long n) {
    int numAs = s.Where(x => x == 'a').Count();
    
    long stringRepetitions = n / s.Length;
    long remainder = n % s.Length;
    long total = stringRepetitions * numAs;

    for(int i = 0; i < remainder; i++){
        if(s[i] == 'a'){
            total++;
        }
    }

    return total;
}
