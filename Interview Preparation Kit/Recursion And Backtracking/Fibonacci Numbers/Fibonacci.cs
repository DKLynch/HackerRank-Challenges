//Problem URL: https://www.hackerrank.com/challenges/ctci-fibonacci-numbers/problem

//Judging by the challenge category, I believe we're supposed to solve this using recursion;
//However, I believe this approach has smaller space complexity and is generally just a more efficient method.
public static int Fibonacci(int n) {
    int[] prevFibNos = new int[2]{0, 1};
    int newFibNo = 0;

    for(int i = 2; i <= n; i++){
        newFibNo = prevFibNos[0] + prevFibNos[1];
        prevFibNos[0] = prevFibNos[1];
        prevFibNos[1] = newFibNo;
    }

    return newFibNo;
}
