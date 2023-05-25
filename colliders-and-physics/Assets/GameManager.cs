// NOTE: If the box above this text note says anything
// other than Assembly-CSharp, autofill will NOT work.
// Unity functions and syntax can be tedious, and it is
// common to make mistakes in commands when there is no guide.
// Library Imports are used to access many of Unity's
// built in C# functions to make game programming easy.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Every Unity script derives from the MonoBehaviour class
// where your script class is the script name you set before.
public class GameManager : MonoBehaviour
{
/* Declaring any object as public will make it available
to be accessed by other scripts. Furthermore, variables
that have been declared public can be seen and edited within
the Unity Inspector for faster gameplay testing */
// When an object does not state its publicity, it is assumed private.
// Variable declarations go here.
// the current game score.
public int score;
// the GameObject that acts as our player object
// will be the Square sprite we created. The GameObject
// type represents any entity within the Unity scene.
public GameObject player;
/* Awake is called at the beginning of the scene.
Start calls before the first frame update, whereas
your game may consist of multiple different scenes.
So when you want a variable to initialize whenever the
scene starts, not the game, you use Awake. */
// Initialization of variables go here.
    void Awake()
    {
        // set our game score to 0 to start
        score = 0;
    }
    // Update is called once per frame. Imagine a while 
    // loop that runs until the game is stopped.
    void Update()
    {
        // if the player object still exists
        // within the scene...
        if (player)
        {
            // increment the score counter.
            score++;
        }
        else
        {
            // otherwise, do not increment.
        }
    }
}