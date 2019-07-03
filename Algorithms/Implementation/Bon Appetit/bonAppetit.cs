//Problem URL: https://www.hackerrank.com/challenges/bon-appetit/problem

static void bonAppetit(List<int> bill, int k, int b) {
    var otherItems = bill.Where((x, y) => y != k);

    int total = 0;
    foreach(int price in otherItems){
        total += price;
    }

    if((total / 2) == b)
        Console.Write("Bon Appetit");
    else
        Console.Write(b - (total / 2));
}
