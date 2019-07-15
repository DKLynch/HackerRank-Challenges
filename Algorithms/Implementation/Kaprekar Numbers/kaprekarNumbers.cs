//Problem URL: https://www.hackerrank.com/challenges/kaprekar-numbers/problem

static void kaprekarNumbers(int p, int q) {
    List<int> kaprekarNums = new List<int>();

    for(int i = p; i <= q; i++){
        long sq = (long) i * i;
        string str = sq.ToString();

        string subStr1 = str.Substring(0, str.Length / 2);
        string subStr2 = str.Substring(str.Length / 2);
        int leftNum = 0;
        int rightNum = 0;

        if(!String.IsNullOrEmpty(subStr1)) leftNum = int.Parse(subStr1);
        if(!String.IsNullOrEmpty(subStr2)) rightNum = int.Parse(subStr2);

        if(leftNum + rightNum == i)
            kaprekarNums.Add(i);
    }

    if(kaprekarNums.Count == 0)
        Console.Write("INVALID RANGE");
    else
        kaprekarNums.ForEach(x => Console.Write(x + " "));
}
