s = 1000
p = float(input())
k = 0
while s<1100:
    s = s*(1+p/100)
    k=k+1
print(k, s)