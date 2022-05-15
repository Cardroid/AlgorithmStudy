import re
import sys

input = sys.stdin.readline

if re.match(r"^(100+1+|01)+$", input()):
    print("SUBMARINE")
else:
    print("NOISE")