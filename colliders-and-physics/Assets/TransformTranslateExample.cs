
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
public class TransformTranslateExample : MonoBehaviour
{
    /* Declaring any object as public will make it available
    to be accessed by other scripts. Furthermore, variables
    that have been declared public can be seen and edited within
    the Unity Inspector for faster gameplay testing */
    // When an object does not state its publicity, it is assumed private.
    // Variable declarations go here.
    // The speed variable of our characters movement.
        public float speed;
    // Start is called before the first frame update.
    // Initialization of variables go here.
    void Start() {
        Vector3 position = new Vector3(0f, 0f, 0f);
        // nothing to be initialized.
    }
// Update is called once per frame. Imagine a while
// loop that runs until the game is stopped.
    void Update() {
        /* Input.GetKey(KeyCode) will return true or false based on whether
        the specified key is being held down. Placing Input.GetKey(KeyCode)
        within a logic statement is how we can prompt the script to
        affect gameplay elements based on the user input.
        Input has other methods, simply type Input. to see
        the autofill prompt the list of different methods.
        Note how gameplay will feel different based on the
        Input methods used and the code's logic structure. */
        /* In order to make our gameobjects move in the Unity
        scene, we type transform.Translate(Vector2)
        transform - to access the transform component of the gameobject.
        Translate() - the Translate method will move the gameobject.
        Vector2 - the velocity of which we move our gameobject. */
        // Be sure to only run one Movement function at a time.
        // All If Statements
        Movement_A();
        // If and Else If
        //Movement_B();
    }
    // First movement function using an all If statement logic structure.
    void Movement_A() {
    // Move up if the Up Arrow is pressed
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // we add Time.deltaTime to keep our movement speed consistent.
            transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);
        }
        // Move down if the Down Arrow is pressed
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);
        }
        // Move right if the Right Arrow is pressed
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime, Space.World);
        }
            // Move lesft if the Left Arrow is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
        }
    }
    // Second movement function using If and Else If statements.
    void Movement_B() {
        // Move up if the Up Arrow is pressed
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        } // Move down if the Down Arrow is pressed
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            // Move right if the Right Arrow is pressed
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            // Move left if the Left Arrow is pressed
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
    }
}
