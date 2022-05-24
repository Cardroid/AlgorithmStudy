import sys

read = sys.stdin.readline


def find(n):
    global parent_node
    
    if n == parent_node[n]:
        return n
    parent_node[n] = find(parent_node[n])
    return parent_node[n]

def union(p_a, p_b):
    global parent_node
    
    p_a = find(p_a)
    p_b = find(p_b)

    if p_b < p_a:
        parent_node[p_a] = p_b
    else:
        parent_node[p_b] = p_a


V, E = map(int, read().split())

edge_list = []
for _ in range(E):
    p_a, p_b, w_c = map(int, read().split())
    edge_list.append((p_a, p_b, w_c))

edge_list.sort(key=lambda x: x[2])

parent_node = list(range(V + 1))

sum = 0
for p_a, p_b, w_c in edge_list:
    if find(p_a) != find(p_b):
        union(p_a, p_b)
        sum += w_c

print(sum)