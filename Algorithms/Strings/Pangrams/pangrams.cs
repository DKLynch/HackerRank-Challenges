//Problem URL: https://www.hackerrank.com/challenges/pangrams/problem

static string pangrams(string s) {
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    string str = s.ToLower();

    foreach(char c in alphabet){
        if(!str.Contains(c.ToString())){
            Console.Write("Couldn't find " + c);
            return "not pangram";   
        }
    }
    return "pangram";
}
