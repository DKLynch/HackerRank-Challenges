//Problem URL: https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem

static int[] rotLeft(int[] a, int d) {
    int[] rotated = new int[a.Length];

    for(int i = 0; i < a.Length; i++){
        rotated[i] = a[(i + d) % a.Length];
    }

    return rotated;
}
