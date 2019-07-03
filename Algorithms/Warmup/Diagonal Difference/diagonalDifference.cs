//Problem URL: https://www.hackerrank.com/challenges/diagonal-difference/problem

public static int diagonalDifference(List<List<int>> arr){
    int length = arr.Count();
    int diagSum1 = 0, diagSum2 = 0;

    for(int i = 0; i < length; i++){
        diagSum1 += arr[i][i];
        diagSum2 += arr[length - 1 - i][i];
    }

    return Math.Abs(diagSum1 - diagSum2);
}
