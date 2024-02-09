def bubble_Sort(array):
    change = True
    offset = 0

    while change == True:
        change = False
        offset += 1
        
        for i in range(0, len(array) - offset):
            bubbleLeft = array[i]

            if bubbleLeft > array[i+1]:
                array[i] = array[i+1]
                array[i+1] = bubbleLeft
                change = True
    
    return array

def insertion_Sort(array):
    for i in range(1, len(array)):
        pointer = i

        while pointer > 0 and array[pointer] < array[pointer - 1]:
            buffer = array[pointer]
            array[pointer] = array[pointer - 1]
            array[pointer - 1] = buffer
            pointer -= 1
    
    return array

def merge_Sort(array):
    mainArray = []
    auxArray = []
    subArray = []

    for item in array:
        mainArray.append([item])
    
    while len(mainArray) != 1:
        for i in range(0, len(mainArray) - 1, 2):
            subcounter1 = 0
            subcounter2 = 0

            for t in range(0, len(mainArray[0]) * 2):

                if subcounter1 >= len(mainArray[i]):
                    for z in range(subcounter2, len(mainArray[i+1])):
                        subArray.append(mainArray[i+1][z])
                    break

                elif subcounter2 >= len(mainArray[i+1]):
                    for z in range(subcounter1, len(mainArray[i])):
                        subArray.append(mainArray[i][z])
                    break
              
                if mainArray[i][subcounter1] < mainArray[i+1][subcounter2]:
                    subArray.append(mainArray[i][subcounter1])
                    subcounter1 += 1
                else:
                    subArray.append(mainArray[i+1][subcounter2])
                    subcounter2 += 1
            
            auxArray.append(subArray)
            subArray = []
                
        if len(mainArray) % 2:
            auxArray.append(mainArray[len(mainArray) - 1])
    
        mainArray = auxArray
        auxArray = []
    
    return mainArray[0]
