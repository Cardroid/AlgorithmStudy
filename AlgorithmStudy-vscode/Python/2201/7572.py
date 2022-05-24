N = int(input()) % 60 - 4

A = N % 10
B = N % 12 + 65

print(chr(B) + str(A))
