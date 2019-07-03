//Problem URL: https://www.hackerrank.com/challenges/cut-the-sticks/problem

static int[] cutTheSticks(int[] arr) {
    List<int> sticksCut = new List<int>();
    var sortedSticks = arr.OrderBy(x => x).ToList();
    int smallestStick = sortedSticks[0];
    int sticksCutThisIteration = 0;
    int remainingSticks = arr.Length;

    while(remainingSticks > 0){
        sticksCutThisIteration = 0;
        smallestStick = sortedSticks.Where(x => x != 0).First();

        for(int i = 0; i < sortedSticks.Count(); i++){
            if(sortedSticks[i] != 0){

                sortedSticks[i] -= smallestStick;
                sticksCutThisIteration++;

                if(sortedSticks[i] == 0){
                    remainingSticks--;
                }
            }
        }

        sticksCut.Add(sticksCutThisIteration);
    }      

    return sticksCut.ToArray();
}
