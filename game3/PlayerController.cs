using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// Private variables
	private float speed = 20.0f;
	private float turnSpeed = 45.0f;
	private float horizontalInput;
	private float forwardInput;
	public float jumpForce;
	private Rigidbody rb;
	 
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		jumpForce = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
		// This is where we get player input
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");
		
		// We move the vehicule forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		// We turn the vehicule
		transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
		// We jump the vehicule
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.velocity = new Vector3 (rb.velocity.x,jumpForce,rb.velocity.z);
		}
    }
}
