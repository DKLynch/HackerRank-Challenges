//Problem URL: https://www.hackerrank.com/challenges/mark-and-toys/problem

static int maximumToys(int[] prices, int k) {
    int numToys = 0;
    int moneyToSpend = k;
    Array.Sort(prices);

    int i = 0;
    while(moneyToSpend > 0 && i < prices.Length){
        if(moneyToSpend > prices[i]){
            numToys++;
            moneyToSpend -= prices[i];
        }

        i++;  
    }
    
    return numToys;
}
