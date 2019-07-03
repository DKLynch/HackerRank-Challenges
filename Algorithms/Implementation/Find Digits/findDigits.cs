//Problem URL: https://www.hackerrank.com/challenges/find-digits/problem

static int findDigits(int n) {
    string s = n.ToString();
    int divisors = 0;

    foreach(char c in s){
        if(n % char.GetNumericValue(c) == 0)
            divisors++;
    }
    return divisors;
}
