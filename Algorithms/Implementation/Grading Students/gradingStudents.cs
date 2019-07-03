//Problem URL: https://www.hackerrank.com/challenges/grading/problem

public static List<int> gradingStudents(List<int> grades)
{
	for(int i = 0; i < grades.Count(); i++){
		if(grades[i] >= 38){
			int difference = 5 - (grades[i] % 5);
			if(difference < 3){
				grades[i] += difference;
			}
		}
	}
	return grades;
}
