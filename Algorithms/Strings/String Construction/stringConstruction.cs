//Problem URL: https://www.hackerrank.com/challenges/string-construction/problem

static int stringConstruction(string s) {
    return s.ToCharArray().Distinct().Count();
}
