number_N = int(input())
number_A, number_B = list(map(float, input().split()))

if number_N > 1 and number_A < number_B:
    the_resulting_string = str((number_B - number_A) / number_N) + " - длина отрезка. "

    time_point = float(number_A)
    while time_point < number_B:
        the_resulting_string += str(time_point) + "; "
        time_point += (number_B - number_A) / number_N
    the_resulting_string += str(float(number_B)) + " - набор точек, образующий разбиение отрезка [A, B]"
    print(the_resulting_string)
else:
    print("input error")