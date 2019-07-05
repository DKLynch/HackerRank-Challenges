//Problem URL: https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

static int[] breakingRecords(int[] scores) {
    int min = scores[0], max = scores[0];
    int minBroken = 0, maxBroken = 0;

    for(int i = 0; i < scores.Length; i++){
        if(scores[i] > max){
            maxBroken += 1;
            max = scores[i];
        }
        else if(scores[i] < min){
            minBroken +=1;
            min = scores[i];
        }
    }

    return new int[]{maxBroken, minBroken};
}
