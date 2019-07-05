//Problem URL: https://www.hackerrank.com/challenges/camelcase/problem

static int camelcase(string s) {
    if(s == "")
        return 0;

    int noWords = 1;
    for(int i = 0; i < s.Length; i++){
        if(char.IsUpper(s[i]))
            noWords++;
    }
    return noWords;
}