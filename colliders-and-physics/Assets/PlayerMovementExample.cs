using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementExample : MonoBehaviour
{
    public float speed; //move speed
    public float height; // jump height

    float thresh; //minimum threshhold for 
    float offset;
    
    public bool isGrounded;
    public bool isRightUp;
    public bool isLeftUp;
    
    public LayerMask layerMask;

    public float raySpawnDist;

    Rigidbody2D square_body; //player rigidbody2D
    // Start is called before the first frame update
    void Awake()
    {
        square_body = GetComponent<Rigidbody2D>();
        offset = speed * 2.5f;

        isRightUp = false;
        isLeftUp = false;
    }

    /** use to call GetButtonUp for the Force Offset */
    void Update()
    {
        if(Input.GetButtonUp("Right")) {
            isRightUp = true;
        }

        if(Input.GetButtonUp("Left")) {
            isLeftUp = true;
        }
    }

    void FixedUpdate() {
        RaycastHit2D hit = Physics2D.Raycast(transform.position - new Vector3(0f, raySpawnDist, 0f), 
                transform.TransformDirection(Vector2.down), 0.01f, layerMask);
        //Debug is required to view raycast in unity editor

        Debug.DrawRay(transform.position - new Vector3(0f, raySpawnDist, 0f),
                transform.TransformDirection(Vector2.down), Color.red);
    }
}
