a, n = float(input()), int(input())
#print(a**n)
q = 1
for i in range(n):
    q *= a
print(q)