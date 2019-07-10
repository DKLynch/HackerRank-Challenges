//Problem URL: https://www.hackerrank.com/challenges/electronics-shop/problem

static int getMoneySpent(int[] keyboards, int[] drives, int b) {
    if(b < keyboards.Min() + drives.Min())
        return -1;

    List<int> sums = new List<int>();
    int sum = 0;

    foreach(int k in keyboards){
        foreach(int d in drives){
            sum = k + d;
            sums.Add(sum);
        }
    }

    sums.Sort();
    return sums.Where(x => x <= b).Last();
}
