//Problem URL: https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem

static int jumpingOnClouds(int[] c) {
    int noJumps = 1;
    int cloud = 0;

    while(cloud < c.Length - 3){
        if(c[cloud + 2] == 0)
            cloud += 2;
        else
            cloud += 1;
        
        noJumps++;
    }
    return noJumps;
}
