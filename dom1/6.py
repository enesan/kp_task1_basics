n = int(input())
a = float(input())
b = float(input())
h = (b-a)/n
print("h = ", h)
z = a
for i in range(0, n+1):
    z=z+h
    print(z)