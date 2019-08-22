#Problem URL: https://www.hackerrank.com/challenges/divisible-sum-pairs/problem

def divisibleSumPairs(n, k, ar):
    counter = 0

    for i in range(0, len(ar)):
        for j in range(0, i):
            if((ar[i] + ar[j]) % k == 0):
                counter += 1

    return counter
