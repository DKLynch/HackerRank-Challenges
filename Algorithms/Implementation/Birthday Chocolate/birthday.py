#Problem URL: https://www.hackerrank.com/challenges/the-birthday-bar/problem

def birthday(s, d, m):
    counter = 0

    for i in range(0, (len(s) - m) + 1):
        sum = 0

        for j in range(i, (i + m)):
            sum += s[j]

        if(sum == d):
            counter += 1
    
    return counter
