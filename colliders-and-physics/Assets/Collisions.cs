using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public bool isPlayerTouching;

    // Start is called before the first frame update
    void Awake()
    {
        isPlayerTouching = false;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(collision.transform.tag == "Enemy") {
            Debug.Log("Touched the player");
            //destroy player
            Destroy(other.gameObject);
            isPlayerTouching = true;
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        Debug.Log(" The " + other.gameObject.name + " is destroyed");
    }
}
