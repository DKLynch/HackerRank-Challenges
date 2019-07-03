//Problem URL: https://www.hackerrank.com/challenges/birthday-cake-candles/problem

static int birthdayCakeCandles(int[] ar) {
	int max = Int32.MinValue;
	int counter = 0;

	for(int i = 0; i < ar.Length; i++){
		if(ar[i] > max){
			max = ar[i];
			counter = 1;
		}
		else if(ar[i] == max){
			counter++;
		}
	}

	return counter;
}
