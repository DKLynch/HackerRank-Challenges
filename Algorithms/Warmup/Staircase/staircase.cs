//Problem URL: https://www.hackerrank.com/challenges/staircase/problem

static void staircase(int n) {
    for(int i = 1; i <= n; i++){
        string str = "";

        for(int j = n - i - 1; j >= 0; j--){
            str += " ";
        }

        for(int k = 1; k <= i; k++){
            str += "#";
        }

        Console.Write(str + "\n");
    }
}
