import sys
from bisect import bisect_left

input = sys.stdin.readline

N = int(input())
array = list(map(int, input().split()))
dp = [0]

for num in array:
    if dp[-1] >= num:
        dp[bisect_left(dp, num)] = num
    else:
        dp.append(num)

print(len(dp) - 1)
