x = int(input('x='))
y = int(input('y='))
if y>0:
    if x<0:
        if x**2+y**2<=1:
            print(0)
        else:
            print(y)
    else:
        if (x**2+y**2<=1) and (x**2+y**2>=0.09):
            print(0)
        else:
            print(y)
else:
    print(y)