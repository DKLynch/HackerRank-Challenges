//Problem URL: https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem

static int minimumAbsoluteDifference(int[] arr) {
    int min = Int32.MaxValue;
	Array.Sort(arr);

    for(int i = 0; i < arr.Length - 1; i++){
        min = Math.Min(min, Math.Abs(arr[i] - arr[i + 1])); 
    }

    return min;
}
