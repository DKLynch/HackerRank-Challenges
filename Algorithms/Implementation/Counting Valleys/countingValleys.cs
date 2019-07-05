//Problem URL: https://www.hackerrank.com/challenges/counting-valleys/problem

static int countingValleys(int n, string s) {
    int currentHeight = 0, noValleys = 0;
    bool isInValley = false;

    for(int i = 0; i < s.Length; i++){
        if(s[i] == 'D'){
            currentHeight--;
        }
        else if(s[i] == 'U'){
            currentHeight++;
        }

        if(currentHeight < 0 && !isInValley){
            isInValley = true;
            noValleys++;
        }

        if(currentHeight >= 0){
            isInValley = false;
        }
    }
    return noValleys;
}