//Problem URL: https://www.hackerrank.com/challenges/reduced-string/problem

static string superReducedString(string s) {
    bool hasMatches = Regex.Match(s, @"/[^\w\s]|(.)\1{1}").Success;

    while(hasMatches){
       s = Regex.Replace(s, @"/[^\w\s]|(.)\1{1}", "");
       hasMatches = Regex.Match(s, @"/[^\w\s]|(.)\1{1}").Success;
    }

    if(s == "")
        return "Empty String";
    else
        return s;
}
