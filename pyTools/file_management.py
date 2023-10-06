import os
import shutil

def wipe_Text_File(dir):
    try: 
        with open(dir, "w") as fileToWipe: pass
    except FileNotFoundError: print("Directory or file does not exist!")

def wipe_Folder(dir):
    try:
        for item in os.listdir(dir): os.remove(f"{dir}/{item}")
    except FileNotFoundError: print("Directory or file does not exist!")

def sort_Folder_Filetype(dir):
    files = os.listdir(dir)
    extensionList = []
    offset = 0

    for i in range(0, len(files)):
        if os.path.splitext(files[i - offset])[1] == "":
            del files[i - offset]
            offset += 1

    for item in files:
        fileTuple = os.path.splitext(item)
        if not fileTuple[1] in extensionList:
            extensionList.append(fileTuple[1])
    
    for item in extensionList:
        item = item[1:]
        try: os.mkdir(f"{dir}/{item}")
        except: print("Folder in extension list already exists!")
    
    for item in files:
        fileTuple = os.path.splitext(item)
        try: shutil.move(f"{dir}/{item}", f"{dir}/{fileTuple[1][1:]}")
        except shutil.Error: print("File or folder already exists!")