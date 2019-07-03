//Problem URL: https://www.hackerrank.com/challenges/time-conversion/problem

static string timeConversion(string s) {
	var timeSuffix = s.Substring(8);
	var digits = s.Substring(0, 8).Split(':').ToList();

	if(timeSuffix == "AM" && digits[0] == "12"){
		digits[0] = "00";
	}
	else if(timeSuffix == "PM"){
		if(int.Parse(digits[0]) != 12){
			digits[0] = (int.Parse(digits[0]) + 12).ToString();
		}
	}
	return (digits[0] + ":" + digits[1] + ":" + digits[2]);
}
