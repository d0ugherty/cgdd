using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

/** The triangles will move between the left and right walls
 *  To do this, the script will determine whether they are moving towards Wall A or Wall B
 *  A vector is calculated towards that wall and the object will move along that vector
**/

public class TriangleMovementRL : MonoBehaviour
{
    public Transform wallA;
    public Transform wallB;
    public float speed = 2f;
    public float stopDistance = 1.0f;
    private bool movingTowardsWallA;
    private Transform targetWall;
  
    private void Awake() {
        targetWall = wallA;
        movingTowardsWallA = true;
    }
    
    private void Update() {
        // get vector between the tgt position and obj current position
        Vector2 dir = targetWall.position - transform.position;

        transform.Translate(dir.normalized * speed * Time.deltaTime);
        // calculate straight-line distance between the current position of the obj and positon of the tgt wall
        float distToTarget = Vector2.Distance(transform.position, targetWall.position);
        // Check if obj has reachted tgt wall
        if (distToTarget <= stopDistance) {
            if (movingTowardsWallA) {
                targetWall = wallA;
            } else {
                targetWall = wallB;
            }
            movingTowardsWallA = !movingTowardsWallA;
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, wallB.position); 
    }
}
