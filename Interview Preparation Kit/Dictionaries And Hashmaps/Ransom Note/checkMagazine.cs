//Problem URL: https://www.hackerrank.com/challenges/ctci-ransom-note/problem

static void checkMagazine(string[] magazine, string[] note) {

    //Create a dictionary from the magazine array, using the string as the key
    //and the occurences of the word in the array as the value
    Dictionary<string, int> magazineWords = magazine.GroupBy(x => x)
        .Select(word => new {word = word.Key, count = word.Count()})
        .ToDictionary(a => a.word, a => a.count);

    foreach(string word in note){
        //If word is not found in dictionary, print No and return
        if(!magazineWords.ContainsKey(word)){
            Console.WriteLine("No");
            return;
        }
        //If we do find a match, decrement the occurence value of the word
        //removing it completely if we hit 0
        else{
            magazineWords[word]--;
            if(magazineWords[word] <= 0){
                magazineWords.Remove(word);
            }              
        }           
    }

    Console.WriteLine("Yes");
}
