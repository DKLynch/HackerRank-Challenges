#Problem URL: https://www.hackerrank.com/challenges/bon-appetit/problem

def bonAppetit(bill, k, b):
    bill.pop(k)

    total = 0
    for price in bill:
        total += price
    
    if((total / 2) == b):
        print("Bon Appetit")
    else:
        print(int(b - (total / 2)))
