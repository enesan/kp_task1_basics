x = int(input('x='))
y = int(input('y='))
if (x**2+y**2<=1) and (y>=x) and (y>=-x):
    print(x+y)
else:
    print(x-y)