def linear_Search(array, toSearch):
    for i in range(0, len(array)):
        if toSearch == array[i]:
            return True
        
    return False

def binary_Search(array, toSearch):
    left = 0
    right = len(array) - 1
    
    while right >= left:
        centre = (left + right) // 2

        if array[centre] == toSearch:
            return True

        elif array[centre] < toSearch:
            left = centre + 1

        else:
            right = centre - 1
    
    return False