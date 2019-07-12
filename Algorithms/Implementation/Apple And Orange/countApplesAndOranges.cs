//Problem URL: https://www.hackerrank.com/challenges/apple-and-orange/problem

static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
    int noApples = 0;
    int noOranges = 0;

    foreach(int apple in apples){
        int landing = a + apple;
        if(landing >= s && landing <= t)
            noApples++;
    }

    foreach(int orange in oranges){
        int landing = b + orange;
        if(landing >= s && landing <= t)
            noOranges++;
    }

    Console.WriteLine(noApples);
    Console.WriteLine(noOranges);
}
