using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// All C# code must be written in classes since it is an Object-Oriented Language.
// The class name MUST MATCH the C# file name (e.g. NumberGuesser.cs)
// MonoBehaviour is the Unity class all our custom classes will derive from.  Class NumberGuesser inerits all
//      features from class MonoBehaviour.  This is all done for us.
public class NumberGuesser : MonoBehaviour  
{
    // instance variables (or attributes of NumberGuesser objects)
    // Variables in C# are strongly typed. You must declare the type (e.g. int, string, bool, etc.) before the name when first used.
    public int max = 1000;  // statements must end with a ;
    public int min = 1;
    private int count = 1;
    private int guess = 0;
    

    // visibility - the visibility of variables can be declared as public or private (default is private)
    //     Making a variable public makes is accesible from the Unity Inspector Window.
    
    // Start method is called before the first frame update (when the object is initialized)
    // void is the return type for the method; all methods have a return type (int, string, bool, etc.).
    //      If nothing is returned, void is the return type.
    void Start()
    {
        print("Welcome to the Number Guesser");
        print("Pick a number in your head");
        // concatenation works similar to Python except type conversion is not necessary.
        print("Pick a number between " + min + " and " + max + "...");
        newGuess();

    }

    // Update method is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))  // check if the user pressed the Up Arrow
        {
            min = guess + 1;
            count++;  // ++ means increment a variable by 1
            newGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess - 1;
            count++;
            newGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Silly human. It only took me " + count + " tries to guess your number.");
        
        }
    }

    // add a new method to our class called newGuess
    void newGuess()
    {
        guess = Random.Range(min, max);
        print("Is the number higher (up arrow) or lower (down arrow) than " + guess + "?  If I got it right press Enter.");
    }








}
