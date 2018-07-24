
class employee:
    __name = ""     # an attribute

    # Constructor
    def __init__(self, name):
        self.__name = name

    # Getter & Setter
    @property
    def employee_name(self):
        return self.__name.upper()
        
    @employee_name.setter
    def employee_name(self, value):
        self.__name = value + " (Name changed. Someone quit!)"

    #  Write employee name
    def getIntro(self):
        return "Name of employee is {}.".format(self.employee_name)
    
def demo_class():
    #Create employee object
    e = employee('James')
    e.employee_name="rey"

    print(e.getIntro())

def main(): 
    demo_class()
    
if __name__ =="__main__":
    main()