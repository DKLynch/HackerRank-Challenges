//Problem URL: https://www.hackerrank.com/challenges/arrays-ds/problem

static int[] reverseArray(int[] a) {
    for(int i = 0; i < Math.Floor(a.Length / 2d); i++){
        int temp = a[i];
        a[i] = a[a.Length - i - 1];
        a[a.Length - i - 1] = temp;
    }
    return a;
}
