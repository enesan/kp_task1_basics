s = 1000
p = int(input())
n = 0
while s <= 1100:
    s = s * (p/100 + 1)
    n += 1
print('k = ', n, 's = ', s)