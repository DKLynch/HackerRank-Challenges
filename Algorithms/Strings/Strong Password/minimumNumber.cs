//Problem URL: https://www.hackerrank.com/challenges/strong-password/problem

static int minimumNumber(int n, string password) {
    bool[] flags = new bool[4];

    for(int i = 0; i < password.Length; i++){
        if(char.IsUpper(password[i]))
            flags[0] = true;
        else if(char.IsLower(password[i]))
            flags[1] = true;
        else if(char.IsDigit(password[i]))
            flags[2] = true;
        else if(char.IsSymbol(password[i]) || char.IsPunctuation(password[i]))
            flags[3] = true;
    }

    int noFlagsNotMet = flags.Count(c => !c);
    int charsNeeded = 0;

    if(password.Length < 6)
        charsNeeded = 6 - password.Length;

    return (charsNeeded > noFlagsNotMet) ? charsNeeded : noFlagsNotMet;
}