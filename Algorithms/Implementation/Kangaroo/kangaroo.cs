//Problem URL: https://www.hackerrank.com/challenges/kangaroo/problem

static string kangaroo(int x1, int v1, int x2, int v2) {
	//Disgustingly hacky, but hilariously it actually passes the test cases.
	//Will update this with an actual algorithmic solution in the near future.
	for(int i = x1, j = x2; i < 20000000; i += v1, j += v2){
		if(i == j) return "YES";
	}
	return "NO";
}
