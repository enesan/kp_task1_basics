x =float(input())
y =float(input())
if (y >= 0) and (x**2 + y**2 <=1):
    if ((x**2 + y**2 >= 0.3**2) and (x > 0)) or (x <= 0):
        print(0)
else:
        print(y)

