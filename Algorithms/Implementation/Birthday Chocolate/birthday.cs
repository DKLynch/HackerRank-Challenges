//Problem URL: https://www.hackerrank.com/challenges/the-birthday-bar/problem

static int birthday(List<int> s, int d, int m) {
	int counter = 0;

	for(int i = 0; i <= s.Count() - m; i++){
		int sum = 0;

		for(int j = i; j < (i + m); j++){
			sum += s[j];
		}
		
		if(sum == d)
			counter++;
	}

	return counter;
}
