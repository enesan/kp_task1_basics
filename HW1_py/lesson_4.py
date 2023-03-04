import math
abciss_X, ordinate_Y = list(map(float, input()))

if ordinate_Y >= 0 and ((abciss_X <= 0 and math.sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) <= 1) or (abciss_X > 0 and math.sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) <= 1 and math.sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) >= 0.3)):
    print("0")
else:
    print(ordinate_Y)