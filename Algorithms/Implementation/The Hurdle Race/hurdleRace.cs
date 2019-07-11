//Problem URL: https://www.hackerrank.com/challenges/the-hurdle-race/problem

static int hurdleRace(int k, int[] height) {
    int doses = height.Max() - k; 
    return (doses >= 0) ? doses : 0;   
}
