using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float sidewaysForce = 5000f;
    public Rigidbody rb; 

    // Update is called once per frame
    void FixedUpdate() // FixedUpdate is better for calculating physics. 
    {
        // It is not good to keep jumps in FixedUpdate, it runs within update. Hence if FixedUpdate runs slow, so will Update. We can miss player input. 
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime); // So that movement is uniform across devices which have different FPS rendering capability. 

        /*
        // This can be made better. Search up in the internet. 
        if( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        */

        rb.AddForce(Input.GetAxis("Horizontal") * sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if( rb.position.y <= 0.8f)
        {
            FindObjectOfType<AudioManager>().Stop("Theme");
            FindObjectOfType<gameManager>().EndGame();
        }

    }
}
