import math
abciss_X, ordinate_Y = list(map(float, input()))

if ordinate_Y >= 0 and math.sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) <= 1 and ordinate_Y > abs(abciss_X):
    print(abciss_X + ordinate_Y)
else:
    print(abciss_X - ordinate_Y)   