//Problem URL: https://www.hackerrank.com/challenges/sock-merchant/problem

static int sockMerchant(int n, int[] ar) {
    int pairs = 0;
    var distinct = ar.Distinct().ToList();

    for(int i = 0; i < distinct.Count(); i++){
        pairs += ((int)Math.Floor(ar.Count(x => x == distinct[i]) / 2d));
    }        
    return pairs;
}
