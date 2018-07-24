# Step 1 - Create abstract base class
class employee():
    def determine_weekly_salary(self, weeklyHours, wage):
        raise NotImplementedError("This abstract method must be implmented by subclass")
 
# Step 2 - Inherit from base & define calculation for permanent employee
class permanent(employee):
    def determine_weekly_salary(self, weeklyHours, wage):
        salary = 40 * wage
        print("\nThis ANGRY EMPLOYEE worked " + str(weeklyHours) + 
              " hrs. Paid for 40 hrs (no overtime) at $ " + str(wage) +
                        "/hr = $"+ str(salary) + " \n")     

# Step 3 - Inherit from base & define calculation for contractor 
class contractor(employee):
     def determine_weekly_salary(self, weeklyHours, wage):
         salary = weeklyHours * wage
         print("\nThis HAPPY CONTRACTOR worked " + str(weeklyHours) + 
              " hrs. Paid for "+ str(weeklyHours) +" hrs (w/ overtime) at $ " + 
              str(wage) + "/hr = $"+ str(salary) + " \n")

# Step 4 - Create permanent / contractor objects & list
def get_employees():
    some_permanent_employee = permanent()
    some_contractor = contractor()
    everyone = [some_permanent_employee,some_contractor]
    return everyone

# Step 5 - Polymorphically calculate salaries 
def main():
    hours = 50; wage = 70
    employees = get_employees()

    for e in employees:
        e.determine_weekly_salary(hours, wage)


if __name__== "__main__":    
    main()   
