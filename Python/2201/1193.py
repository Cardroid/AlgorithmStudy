n = int(input())

l = 0
m = 0
while n > m:
    l += 1
    m += l

k = m - n

if l % 2 != 0:
    d = l - k
    u = k + 1
else:
    d = k + 1
    u = l - k

print(str(u) + "/" + str(d))
