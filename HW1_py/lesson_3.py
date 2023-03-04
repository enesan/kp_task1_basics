import math
abciss_X, ordinate_Y = list(map(float, input()))

if math.sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) >= 1 and math.sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) <= 2 and ordinate_Y >= 0:
    print("1")
else:
    print("0")
