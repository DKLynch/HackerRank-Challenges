//Problem URL: https://www.hackerrank.com/challenges/smart-number/problem

bool is_smart_number(int num) {
    int val = (int) sqrt(num);
    if(val * val == num)
        return true;
    return false;
}

/*Template code to be fixed:

bool is_smart_number(int num) {
    int val = (int) sqrt(num);
    if(num / val == 1)
        return true;
    return false;
}

*/
