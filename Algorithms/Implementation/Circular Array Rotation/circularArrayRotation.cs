//Problem URL: https://www.hackerrank.com/challenges/circular-array-rotation/problem

static int[] circularArrayRotation(int[] a, int k, int[] queries) {
    int[] rotated = new int[a.Length];

    for(int i = 0; i < a.Length; i++){
        rotated[(i + k) % a.Length] = a[i];
    }

    for(int i = 0; i < queries.Length; i++){
        queries[i] = rotated[queries[i]];
    }
    
    return queries;
}
