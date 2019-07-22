//Problem URL: https://www.hackerrank.com/challenges/encryption/problem

static string encryption(string s) {
    string str = s.Replace(" ", "");
    double sqrt = Math.Sqrt(str.Length);
    int columns = (int)Math.Ceiling(sqrt);
    int rows = (int)Math.Floor(sqrt);

    if(rows * columns < str.Length){
        rows = columns;
    }

    string res = "";
    for(int i = 0; i < columns; i++){
        int j = 0;

        //Column + (row * row width)
        //ie. if our no of columns and no of rows = 4,
        //0 + (0 * 4) yields 0 for our first character,
        //0 + (1 * 4) yields 4 for our second (the first character of the second row)
        while(i + (j * columns) < str.Length){
            res += str[i + (j * columns)];
            j++;
        }
        
        //Append a space after each 'column' is written out
        //Except for when we're on the final loop iteration
        if(i != columns - 1)
            res += " ";
    }

    return res;
}
