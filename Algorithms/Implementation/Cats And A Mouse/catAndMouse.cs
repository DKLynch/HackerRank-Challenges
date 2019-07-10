//Problem URL: https://www.hackerrank.com/challenges/cats-and-a-mouse/problem

static string catAndMouse(int x, int y, int z) {
    int catADistance = Math.Abs(z - x);
    int catBDistance = Math.Abs(z - y);

    if(catADistance > catBDistance)
        return "Cat B";      
    if(catBDistance > catADistance)
        return "Cat A";
    else
        return "Mouse C";
}
