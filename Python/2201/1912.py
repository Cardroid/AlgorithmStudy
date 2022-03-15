input()

array = list(map(int, input().split()))

l = [i for i in range(len(array))]
l[0] = array[0]

for i in range(1, len(array)):
    l[i] = max(array[i], l[i - 1] + array[i])

print(max(l))
