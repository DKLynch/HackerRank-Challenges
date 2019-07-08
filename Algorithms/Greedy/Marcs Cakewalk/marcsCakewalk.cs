//Problem URL: https://www.hackerrank.com/challenges/marcs-cakewalk/problem

static long marcsCakewalk(int[] calorie) {
    long miles = 0;
    Array.Sort(calorie);
    
    for(int i = 0; i < calorie.Length; i++){
        miles += (long)(Math.Pow(2, i) * calorie[calorie.Length - i - 1]);
    }

    return miles;
}
