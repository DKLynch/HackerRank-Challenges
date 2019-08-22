#Problem URL: https://www.hackerrank.com/challenges/migratory-birds/problem

def migratoryBirds(arr):
    occurences = [0]*6
    for b in arr:
        occurences[b] += 1
    
    return occurences.index(max(occurences))
