//Problem URL: https://www.hackerrank.com/challenges/drawing-book/problem

static int pageCount(int n, int p) {
    return Math.Min(p/2, n/2-p/2);
}
