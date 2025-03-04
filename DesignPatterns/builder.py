class Application:
    def __init__(self):
        self.configA=0
        self.configB=0
        self.configC=0
    
    def add_all_config(self):
        return self.configA+self.configB+self.configC
    

class ApplicationBuilder:
    def __init__(self):
        self.application=Application()

    def set_configA(self,configA):
        self.application.configA=configA
        return self
    
    def set_configB(self,configB):
        self.application.configB=configB
        return self
    
    def set_configC(self,configC):
        self.application.configC=configC
        return self
    
    def build(self):
        return self.application
    

if __name__ == "__main__":
    builder=ApplicationBuilder()
    application=builder.set_configA(3).set_configB(2).set_configC(3).build()
    print(application.add_all_config())  # Output: 6
    
