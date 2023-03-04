number_A = float(input())
number_N = int(input())

if number_N > 0:
    result = int(1)
    for i in range(number_N):
        result *= number_A
    print(result)
else:
    print("input error")