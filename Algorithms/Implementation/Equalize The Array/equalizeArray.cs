//Problem URL: https://www.hackerrank.com/challenges/equality-in-a-array/problem

static int equalizeArray(int[] arr) {
    int mostCommon = arr.GroupBy(x => x)
                        .OrderByDescending(g => g.Count())
                        .First()
                        .Key;

    return arr.Count(x => x != mostCommon);                  
}
