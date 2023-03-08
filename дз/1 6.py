n, a, b = int(input()), float(input()), float(input())
l = b - a
h = l / n
x = a
print('h = ', h)
for n in range (n+1):
    print(x, '; ', end='')
    x += h

