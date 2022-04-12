import re
import sys

input = sys.stdin.readline

testCase = int(input())
regex = re.compile(r"^[A-F]?A+F+C+[A-F]?$")

for i in range(testCase):
    text = input()

    if regex.match(text) != None:
        print("Infected!")
    else:
        print("Good")
