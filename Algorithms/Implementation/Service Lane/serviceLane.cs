//Problem URL: https://www.hackerrank.com/challenges/service-lane/problem

//NOTE: There were some issues with the premade template for this problem;
//Originally, the width array was not passed as a parameter.
//You may need to fix this manually like I have.
//I have appended the rest of the template below and commented the line changes made.

//Method declaration used to be:
//static int[] serviceLane(int n, int[][] cases) {
//}
//Amended to:
static int[] serviceLane(int n, int[][] cases, int[] width) {
    List<int> safeSizes = new List<int>();

    foreach(int[] c in cases){
        int min = Int32.MaxValue;
        for(int i = c[0]; i <= c[1]; i++){
            min = Math.Min(min, width[i]);
        }

        safeSizes.Add(min);
    }
    return safeSizes.ToArray();
}

static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nt = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nt[0]);

        int t = Convert.ToInt32(nt[1]);

        int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
        ;

        int[][] cases = new int[t][];

        for (int i = 0; i < t; i++) {
            cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
        }

//      This line used to be:
//      int[] result = serviceLane(n, cases);
//      Amended to:
        int[] result = serviceLane(n, cases, width);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
