﻿//PROGRAM
//What is the initial passcode? 1234
//The door is Closed. What do you want to do? (open, close, lock, unlock, change code) lock
//The door is Locked.What do you want to do? (open, close, lock, unlock, change code) unlock
//What is the passcode? - if matches then 'The door is Closed...', if not match then 'The door is Locked...'
//The door is Closed. What do you want to do? (open, close, lock, unlock, change code) change code
//What is the current passcode? 1234 (if matches then next time you unlock it'll change to Closed, if doesn't match then next time you unlock it'll stay on Locked)

public class Door
{
    DoorState ManipulateDoor(string input)
    {
        if (input == "close" || input == "unlock") return DoorState.Closed;
        else if (input == "lock") return DoorState.Locked;
        else return DoorState.Open;
    }
}

enum DoorState { Open, Closed, Locked }