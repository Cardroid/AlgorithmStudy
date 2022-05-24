import re
import sys

input = sys.stdin.readline

testCase = int(input())

reg = re.compile(r"^(100+1+|01)+$")

for i in range(testCase):
    input_str = input()

    if reg.match(input_str):
        print("YES")
    else:
        print("NO")