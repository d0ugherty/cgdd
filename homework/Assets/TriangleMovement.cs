using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

/** The triangles will move between the left and right walls
 *  To do this, the script will determine whether they are moving towards Wall A or Wall B
 *  A vector is calculated towards that wall and the object will move along that vector
**/

public class TriangleMovement : MonoBehaviour
{
    public GameObject wallA;
    public GameObject wallB;
    public float speed = 2f;

    private bool movingTowardsWallA = true;

    private void Update()
    {
        Vector2 targetPosition;
        Debug.Log(Vector2.Distance(transform.position, wallA.transform.position));
        if (movingTowardsWallA)
        {
            targetPosition = wallA.transform.position;
        }
        else
        {
            targetPosition = wallB.transform.position;
        }

        Vector2 direction = targetPosition - (Vector2)transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime);
        // Check if the object has reached the target wall
        if (movingTowardsWallA && Vector2.Distance(transform.position, wallA.transform.position) < 1.5f)
        {
            movingTowardsWallA = false;
        }
        else if (!movingTowardsWallA && Vector2.Distance(transform.position, wallB.transform.position) < 1.5f)
        {
            movingTowardsWallA = true;
        }
    }
}
