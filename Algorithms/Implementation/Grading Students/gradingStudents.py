#Problem URL: https://www.hackerrank.com/challenges/grading/problem

def gradingStudents(grades):
    for x in range (0, len(grades)):
        if(grades[x] >= 38):
            difference = 5 - (grades[x] % 5)
            if(difference < 3):
                grades[x] += difference
    
    return grades
