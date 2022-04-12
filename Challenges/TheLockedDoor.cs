﻿//SimulasTest might help!

//DOOR RULES:
//1: An open door can be closed
//2: A closed (but not locked) door can be opened
//3: A closed door can be locked
//4: A locked door can be unlocked, but numeric password is needed and will only unlock if the code provided matches the door's current passcode
//5: When a door is created, it must be given an initial passcode
//6: You should be able to change the passcode by supplying the current code and a new one. It should only change if the correct current code is given

//OBJECTIVES

DoorState currentDoorState = DoorState.Locked;

//Make your Main method ask the user for a starting passcode, then create a new Door instance
Console.WriteLine("Please create a four digit passcode");
int userPasscode = Convert.ToInt32(Console.ReadLine());
//Allow the user to attempt the four transitions (open, close, lock, unlock)
Console.WriteLine($"The door is currently {currentDoorState}. What do you want to do?");
//and change the code by typing in text commands

//Define a Door class that can keep track of whether it is locked, open or closed
public class Door
{


    bool CheckActionAllowed(DoorState state, string input)
    {
        if (input == "close" && state == DoorState.Open
            || input == "lock" && state == DoorState.Closed
            || input == "open" && state == DoorState.Closed
            || input == "unlock" && state == DoorState.Locked) //numeric password required
            return true;
        else return false;
    }
    DoorState SetChestState(string input)
    {
        if (input == "close" || input == "unlock") return DoorState.Closed;
        else if (input == "lock") return DoorState.Locked;
        else return DoorState.Open;
    }
}
//Create methods to perform the four transitions defined above
//Build a constructor that requires the starting numeric passcode
//Build a method that will allow you to change the passcode for an existing door by supplying the current passcode and a new passcode. Only change the passcode is
//the current one is correct


enum DoorState { Open, Closed, Locked }