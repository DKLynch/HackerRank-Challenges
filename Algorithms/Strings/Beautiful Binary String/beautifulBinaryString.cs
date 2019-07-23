//Problem URL: https://www.hackerrank.com/challenges/beautiful-binary-string/problem

//We simply need to count how many times "010" occurs
//Because we can replace each occurence of "010" with "011"
//And avoid making any new occurences of "010 at the cost of 1 character per occurence.
//Ex. (010)1(010)10 --> (011)1(011)10

static int beautifulBinaryString(string b) {
    string pattern = @"(010)";
    return Regex.Matches(b, pattern).Count;
}
