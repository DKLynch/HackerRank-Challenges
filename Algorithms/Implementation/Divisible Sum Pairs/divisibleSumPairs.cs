static int divisibleSumPairs(int n, int k, int[] ar) {
	int counter = 0;

	for(int i = 0; i < ar.Length; i++){
		for(int j = 0; j < i; j++){
			if((ar[i] + ar[j]) % k == 0){
				   counter++;
			}
		}
	}
	return counter;
}
