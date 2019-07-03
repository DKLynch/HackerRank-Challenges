//Problem URL: https://www.hackerrank.com/challenges/plus-minus/problem

static void plusMinus(int[] arr) {
    int positive = 0;
    int negative = 0;
    int zero = 0;

    foreach(int i in arr){
        if(i == 0)
            zero++;
        else if(i > 0)
            positive++;
        else
            negative++;
    }
    
    Console.WriteLine((float)positive / arr.Length);
    Console.WriteLine((float)negative / arr.Length);
    Console.WriteLine((float)zero / arr.Length);
}
