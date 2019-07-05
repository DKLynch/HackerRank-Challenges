//Problem URL: https://www.hackerrank.com/challenges/strange-advertising/problem

static int viralAdvertising(int n) {
    int likesTally = 0, likes = 0;
    int views = 5;

    for(int i = 1; i <= n; i++){
        likes = (int)Math.Floor(views/2d);
        likesTally += likes;
        views = (likes * 3);
    }
    return likesTally;
}