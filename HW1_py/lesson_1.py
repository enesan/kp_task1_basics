number = int(input())
if number % 2 == 0 and int(number / 10) > 0 and int(number / 10) < 10:
    print("true")
else:
    print("false")