//Problem URL: https://www.hackerrank.com/challenges/the-time-in-words/problem

static string timeInWords(int h, int m) {
    int hIndex = h - 1;
    int mIndex = m - 1;

    string[] hours = new[]{"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };

    string[] minutes = new[]{"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
		"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen","nineteen", "twenty",
		"twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine" };

    if(m == 0)
        return hours[hIndex] + " o' clock";

    else if(m == 15)
        return "quarter past " + hours[hIndex];

    else if(m == 30)
        return "half past " + hours[hIndex];

    else if(m == 45)
        return "quarter to " + hours[hIndex + 1];

    else if(m == 1)
        return minutes[mIndex] + " minute past " + hours[hIndex];

    else if((m > 1 && m < 15) || (m > 15 && m < 30))
        return minutes[mIndex] + " minutes past " + hours[hIndex];

    else if((m > 30 && m < 45) || (m > 45 && m < 60))
        return minutes[60 - m - 1] + " minutes to " + hours[hIndex + 1];

    return null;
}
