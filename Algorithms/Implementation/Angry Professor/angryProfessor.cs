//Problem URL: https://www.hackerrank.com/challenges/angry-professor/problem

static string angryProfessor(int k, int[] a) {
    return a.Count(x => (x <= 0)) < k ? "YES" : "NO";
}
