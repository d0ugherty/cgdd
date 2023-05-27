using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour{
    public float speed; //move speed
    public float height; // jump height
    public InputAction rightActionVar;
    public InputAction leftActionVar;
    float thresh; //minimum threshhold for 
    float offset;
    
    public bool isGrounded;
    public bool isRightUp;
    public bool isLeftUp;
    //Layers are identifiers for objects in space. LayerMask refers the collection of layers included in the statement 
    // Basically, LayerMask is used to hit only those layers with the Raycast method
    public LayerMask layerMask; 

    public float raySpawnDist;

    Rigidbody2D square_rbody; //player rigidbody2D
    // Start is called before the first frame update
    void Awake()
    {
        square_rbody = GetComponent<Rigidbody2D>();
        offset = speed * 2.5f;

        isRightUp = false;
        isLeftUp = false;
        thresh = speed/10000;
    }

    private void OnEnable(){
        rightActionVar = new InputAction("Right", InputActionType.Button, "<Keyboard>/rightArrow");
        rightActionVar.Enable();
        leftActionVar = new InputAction("Left", InputActionType.Button, "<Keyboard>/leftArrow");
        leftActionVar.Enable();
    }

    private void OnDisable(){
        rightActionVar.Disable();
        leftActionVar.Disable();
    }
    /** use to call GetButtonUp for the Force Offset */
    void Update()
    {
        // check if left or right buttons have been released
       if (rightActionVar.triggered) {
            isRightUp = true;
        }

        if(leftActionVar.triggered) {
            isLeftUp = true;
        }
    }

    /** FixedUpdate runs once every few frames whereas Update() runs every frames*/
    void FixedUpdate() {
        RaycastHit2D hit = Physics2D.Raycast(transform.position - new Vector3(0f, raySpawnDist, 0f), 
                transform.TransformDirection(Vector2.down), 0.01f, layerMask);
        //Debug is required to view raycast in unity editor

        Debug.DrawRay(transform.position - new Vector3(0f, raySpawnDist, 0f),
                transform.TransformDirection(Vector2.down), Color.red);

        if (hit.collider != null) {
            isGrounded = true;
        }

        if(Input.GetButton("Jump") && isGrounded) {
            //Apply force upwards
            square_rbody.AddForce(Vector2.up * height * Time.deltaTime, ForceMode2D.Impulse);
            isGrounded = false;
        }

        if (isRightUp) {
        // Handle right movement
            if (square_rbody.velocity != Vector2.zero){
                square_rbody.AddForce(Vector2.left * offset * Time.deltaTime);
            }
        isRightUp = false;
        }    

        if (isLeftUp){
        // Handle left movement
            if (square_rbody.velocity != Vector2.zero) {
                square_rbody.AddForce(Vector2.right * offset * Time.deltaTime);
            }   
        isLeftUp = false;
        }
    }
}
