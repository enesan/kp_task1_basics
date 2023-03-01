x = int(input())
y = int(input())
if y>0:
    if ((x**2+y**2)<=4) and (x**2+y**2>=1):
        print('1')
    else:
        print('0')
else:
    print('0')