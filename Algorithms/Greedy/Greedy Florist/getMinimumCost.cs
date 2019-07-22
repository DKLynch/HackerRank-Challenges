//Problem URL: https://www.hackerrank.com/challenges/greedy-florist/

static int getMinimumCost(int k, int[] c) {
    Array.Sort(c);

    int minCost = 0;
    int flowersBought = 0;
    int currentPerson = k;

    //Each person buys the most expensive flower at the time,
    //Utilizing the lowest possible multiplier from previously bought flowers
    for(int i = c.Length - 1; i >= 0; i--){ 
       minCost += (flowersBought + 1) * c[i];
       currentPerson--;

       //Increment the flowers bought multiplier once we've cycled
       //through each person once
       if(currentPerson == 0){
           flowersBought++;
           currentPerson = k;
       }
    }
    
    return minCost;
}
