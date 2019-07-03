//Problem URL: https://www.hackerrank.com/challenges/extra-long-factorials/problem

static void extraLongFactorials(int n) {
    BigInteger factorial = n;
    for(int i = n - 1; i > 0; i--){
        factorial *= i;
    }
    Console.Write(factorial);
}
