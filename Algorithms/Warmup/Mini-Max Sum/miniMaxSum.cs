//Problem URL: https://www.hackerrank.com/challenges/mini-max-sum/problem

static void miniMaxSum(int[] arr) {
	List<long> sums = new List<long>();

	for(int i = 0; i < arr.Length; i++){
		var otherNums = arr.Where((x, j) => j != i);
		
		long sum = 0;
		foreach(long n in otherNums){
			sum += n;
		}

		sums.Add(sum);                      
	}       
	
	Console.Write(sums.Min().ToString() + " " + sums.Max().ToString());
}
