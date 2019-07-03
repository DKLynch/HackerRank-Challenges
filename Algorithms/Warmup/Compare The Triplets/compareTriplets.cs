//Problem URL: https://www.hackerrank.com/challenges/compare-the-triplets/problem

static List<int> compareTriplets(List<int> a, List<int> b) {
    int sumA = 0;
    int sumB = 0;
        
    for(int i = 0; i < a.Count(); i++){
        if (a[i] < b[i])
            sumB += 1;
        else if (a[i] > b[i])
            sumA += 1;
		}
    return new List<int> {sumA, sumB};
}
