//Problem URL: https://www.hackerrank.com/challenges/migratory-birds/problem

static int migratoryBirds(List<int> arr) {
    return arr.GroupBy(x => x)
        .OrderBy(x => x.Key)
        .OrderByDescending(x => x.Count())
        .First()
        .Key;
}
