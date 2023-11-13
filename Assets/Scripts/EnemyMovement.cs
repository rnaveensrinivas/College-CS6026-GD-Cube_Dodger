using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float forwardForce = 1000f;
    public Rigidbody rb; 

    

    // Update is called once per frame
    void FixedUpdate() // FixedUpdate is better for calculating physics. 
    {
        // It is not good to keep jumps in FixedUpdate, it runs within update. Hence if FixedUpdate runs slow, so will Update. We can miss player input. 
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange); // So that movement is uniform across devices which have different FPS rendering capability.         

    }

}
