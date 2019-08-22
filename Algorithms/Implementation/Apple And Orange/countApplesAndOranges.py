#Problem URL: https://www.hackerrank.com/challenges/apple-and-orange/problem

def countApplesAndOranges(s, t, a, b, apples, oranges):
    noApples = 0
    noOranges= 0

    for apple in apples:
        landing = a + apple
        if(landing >= s and landing <= t):
            noApples += 1
    
    for orange in oranges:
        landing = b + orange
        if(landing >= s and landing <= t):
            noOranges += 1
    
    print(noApples)
    print(noOranges)
