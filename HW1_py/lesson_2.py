number = input()
if int(number) > 999 and int(number) < 10000:
    if number[0] == number[3] and number[1] == number[2]:
        print("true")
    else:
        print("false")
else:
    print("input error")