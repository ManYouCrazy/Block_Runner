using UnityEngine;



public class PlayerMovment : MonoBehaviour
{
	// Vars/other important stuff
	public Rigidbody rb;
	public float speed = 2000f;
	public float sidwaysSpeed = 1250f;
	

	
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
		
		
		
		if ( Input.GetKey("d") )
		{
			rb.AddForce (sidwaysSpeed*Time.deltaTime,0,0);
		}
		
		if ( Input.GetKey("a") )
		{
			rb.AddForce (-sidwaysSpeed*Time.deltaTime,0,0);
		}
    }
}
