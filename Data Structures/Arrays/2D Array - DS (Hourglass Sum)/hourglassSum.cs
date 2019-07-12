//Problem URL: https://www.hackerrank.com/challenges/2d-array/problem

static int hourglassSum(int[][] arr) {
    int maxSum = Int32.MinValue;

    for(int i = 0; i < arr.Length - 2; i++){
        for(int j = 0; j < arr[0].Length - 2; j++){
            int sum =   arr[i][j] +
                        arr[i][j + 1] +
                        arr[i][j + 2] +
                        arr[i + 1][j + 1] + 
                        arr[i + 2][j] +
                        arr[i + 2][j + 1] +
                        arr[i + 2][j + 2];

            maxSum = Math.Max(maxSum, sum);      
        }
    }

    return maxSum;
}
