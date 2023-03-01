''' #1
a = int(input())
if a%100 == a and a%2 == 0: print('true')
else: print('false')'''

''' #2
a = int(input())
if a//100 == a%10*10 + a%100//10: print('true')
else: print('false')'''

'''#3
x = float(input())
y = float(input())
if (y > 0 and y * y + x * x > 1 and y * y + x * x < 4): print(1)
else: print(0)'''

'''#4
x = float(input())
y = float(input())
if (y > 0 and y * y + x * x > 1):
     if (x < 0.3 and x > 0 and y > 0 and y * y + x * x < 0.3*0.3): print(y)
     else: print(0)
else: print(y)'''


'''#5
x = float(input())
y = float(input())
if (y > -x and y > x and y * y + x * x < 1): print(x + y)
else: print(x - y)'''

'''#6
N = int(input())
A = float(input())
B = float(input())
H = int((B - A) / N)
print(H)
while (A <= B):
    print(A)
    A = A + H'''

'''#7
a = int(input())
n = int(input())
print(a**n)'''


#8
p = int(input())
s = 1000
k = 0
while s <= 1100:
    s += s / 100 * p;
    k += 1
print(k, s)