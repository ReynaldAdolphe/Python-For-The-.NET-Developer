
def demo_if():
    testGrade = 95

    # Ex: if
    if testGrade>85:
        print("You did good!") 
    else:
        print("You did not work hard!")
    
    # Ex: elif
    if testGrade > 94:
        print("You did awesome!")
    elif testGrade > 85:
        print("You did good!")
    else:
        print("You did not work hard!")

    # Ex: multiple operators
    if ((testGrade >= 90) and (testGrade <= 95)):
        print("You almost reached excellence!")

def demo_lists():
    #Create, print entire list & just first friend
    print('Create, print entire list & just first friend')
    print('---------------------------------------------')
    friend_list = ['Sky', 'Marcel', 'Robin', 
                  'Khaleel', 'Connie']
    print('All Friends =', friend_list)
    print('First Friend =', friend_list[0])

    #Change value
    friend_list[0] = "Taylor"
    print('First Friend with name change =', friend_list[0])

    #Print partial list
    print('Partial list of friends =' + str(friend_list[2:5]))

    #List within lists
    family_list = ['Mom', 'Dad', 'Cousin']
    people_list = [friend_list,family_list]
    print('\nWrite out people_list:')
    print('-----------------------')
    print(people_list)
    print('\nWrite 3rd element from 2nd list:')
    print('-----------------------------------')
    print('Third person in 2nd list is:' + (people_list[1][2]))

def demo_for_loops():
    #Print from 0 to 4
    print("\n*Print from 0 to 4")
    for i in range(0,5):
        print(i, ' ', end="") 

    #Print list using 'for'
    print("\n*Print list using 'for'")
    friend_list = ['Sky', 'Marcel', 'Robin','Khaleel', 'Connie']
    for list in friend_list:
        print(list)

    #List within list aka 2-dimensional array
    print("\n*Printing nested loop")
    array_of_people = [["Robin", "Khaleel", "Connie"],["Mom","Dad","Sister"]]
    for x in range(0,2):
        for y in range(0,3):
            print(array_of_people[x][y]) 

    #Continue, Break
    my_items = ['answer', 'amazon', 'banana', 'badger', 'clementine',
    'camel']
    print("\n*Ex: 'continue' from list: " + str(my_items))
    
    for item in my_items:
        if item.startswith('b'):
            continue
        print(item)
        
    print("\n*Ex: 'break' from list: " + str(my_items))   
    for item in my_items:
        if item.startswith('b'):
            break
        print(item)

def demo_while_loops():
    print("\n*While loop demo")
    x = 0
    while (x < 5):
        print("Today, I've got time, son!")
        x = x + 1

def demo_dictonary():
    favorite_movie = {'Reynald' : 'Titanic',
                        'Marcel' : 'Enter the Dragon',
                        'Khaleel' : 'The Notebook',
                        'Connie' : 'Superman'}

    print("No shame, Reynald's fav movie is " + favorite_movie['Reynald'])

    print(favorite_movie)                       #print entire dictionary
    del favorite_movie['Connie']                #delete value
    favorite_movie['Khaleel'] = "Star Wars"     #replace value

    print("\nReprinting dictionary after modifications")
    print(favorite_movie)                       #reprint entire dictionary



def main():
    #demo_if()  
    #demo_lists() 
    #demo_for_loops()
    #demo_while_loops()
    demo_dictonary()
    
if __name__ =="__main__":
    main()