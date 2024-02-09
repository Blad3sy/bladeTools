import time

class Timer:
    def __init__(self, start = False):
        self.startTime, self.endTime = None, None
        if start: self.startTimer()
    
    def startTimer(self):
        self.startTime = time.time()
    
    def stopTimer(self):
        if self.startTime: self.endTime = time.time()
        else: print("You never started the timer!")
    
    def reportTimeInterval(self):
        return round(self.endTime - self.startTime, 2)
    
    def resetTimer(self):
        self.startTime, self.endTime = None, None
    
    def finishTimer(self):
        self.stopTimer()
        print(f"Time elapsed: {self.reportTimeInterval()} seconds.")
        self.resetTimer()
    
    def lapTimer(self):
        self.finishTimer()
        self.startTimer()