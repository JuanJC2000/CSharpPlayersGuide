//With the enumeration defined below, we can now use it like any other type.
ChestState current = default; //Deafult value is the first enumeration item, in this case locked.
                              //Only legimitate states of the enumeration can be assigned.
                              //We can access specific enumeration value through the enumeration type name and the dot operator.

//Create an infinite loop 
while (true)
{
    //Shows the currernt value of variable current. On the first loop, this is default; Locked. On every other loop, thanks to our switch case, it will show the specific value we want.
    Console.Write($"The chest is {current}. What do you want to do? ");
    string response = Console.ReadLine();
    
    switch (response)
    {
        //If string response = lock, then do this. 
        case "lock":
            if (current != ChestState.Closed && current != ChestState.Unlocked) //We can only lock the chest if the chest is currently closed or unlocked. We cannot lock it if it is open, of it is already locked.
                                                                                // This is quite cool bool logic, saving us multiple if statements by simply checking if we are not a current viable value.
                continue; //If its not any of these, then just continue or next iteration of our loop. This ensures only supported transition between states is allowed.
            current = ChestState.Locked; //else, meaning that the chest is either closed or unlocked, change our current value to the enum value type Locked.
          
            continue;   //This program idenfinitley runs, so we can use continue instead of break.

        case "unlock":      //The same logic is used here as it is above, but we dont need to use multiple conditions because there is only possible state to get out a locked chest, to unlock it.
            if (current != ChestState.Locked)
                continue;
            current = ChestState.Unlocked;
            
            continue;

        case "open": //Same logic, but once again opening the chest can happen from 2 instances, either closed or just unlocked, so we have to check them both.
            if (current != ChestState.Closed && current != ChestState.Unlocked)
                continue;
            current = ChestState.Open;
            
            continue;

        case "close":  //You can only close a chest once it is open, so only one condition to check.
            if (current != ChestState.Open)
                continue;
            current = ChestState.Closed;
            
            continue;

        //If the user inputs anything else, we can just say to try again.
        default: Console.WriteLine("Try Again"); 
            continue;
    }
    
}

//Define enumeration of chest states
enum ChestState { 
    Locked, //each of these are options for the enumeration
    Unlocked, 
    Closed, 
    Open 
}  // New types MUST go after other
            // code (or in another file).
    