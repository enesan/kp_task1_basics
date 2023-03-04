abciss_X, ordinate_Y = list(map(float, input()))

if abciss_X <= -10 or (abciss_X >= -3 and abciss_X <= 3) or abciss_X >= 5:
    print("true")
else:
    print("false")
