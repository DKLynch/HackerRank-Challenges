//Problem URL: https://www.hackerrank.com/challenges/utopian-tree/problem

static int utopianTree(int n) {
    int totalHeight = 1;
    
    for(int i = 0; i < n; i++){
        if(i % 2 != 0 && i != 0)
            totalHeight += 1;
        else if(i % 2 == 0)
            totalHeight *= 2;
    }
    return totalHeight;
}