//Problem URL: https://www.hackerrank.com/challenges/mars-exploration/problem

static int marsExploration(string s) {
    string baseSOS = "SOS";
    List<string> messages = new List<string>();
    int differentChars = 0;

    for (int i = 0; i < s.Length; i += 3) {
        messages.Add(s.Substring(i, 3));
    }

    foreach(string m in messages){
        for(int i = 0; i < m.Length; i++){
            if(m[i] != baseSOS[i])
                differentChars++;
        }
    }
    return differentChars;
}
