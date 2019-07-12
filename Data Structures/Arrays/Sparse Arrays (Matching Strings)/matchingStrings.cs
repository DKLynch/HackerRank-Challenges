//Problem URL: https://www.hackerrank.com/challenges/sparse-arrays/problem
//Problem doesn't actually really teach much about sparse arrays in my opinion, not sure why it's titled as such.

static int[] matchingStrings(string[] strings, string[] queries) {
    int[] totals = new int[queries.Length];

    for(int i = 0; i < queries.Length; i++){
        totals[i] = strings.Count(s => s == queries[i]);
    }
    
    return totals;
}
