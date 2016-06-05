import math

def f(x):
    return math.sqrt(x + 5.0 * pow(x, 3))

limit = 400
message = "Very Large Value"
array = []

for x in range(10):
    array.append(input())

array = reversed(array)

for x in array:
    y = f(x)
    print(y if y < limit else message)
