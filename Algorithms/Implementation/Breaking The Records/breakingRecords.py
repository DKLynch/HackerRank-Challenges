#Problem URL: https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

def breakingRecords(scores):
    min = scores[0]
    max = scores[0]
    minBroken = 0
    maxBroken = 0

    for i in range(0, len(scores)):
        if(scores[i] > max):
            maxBroken += 1
            max = scores[i]
        elif(scores[i] < min):
            minBroken += 1
            min = scores[i]
    
    return [maxBroken, minBroken]
