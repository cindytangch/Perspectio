using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement03 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 8f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    [SerializeField] AudioSource jumpSound;

		[SerializeField] float zTranslation1 = 0;
		[SerializeField] float zTranslation2 = 0;
		[SerializeField] float zTranslation3 = 0;
		[SerializeField] float zTranslation4 = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
	  		float verticalInput = Input.GetAxis("Vertical");

	  		if (CameraChange.CamMode == 0) {
	  			rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, 0);
	  		}
				else {
	  			rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
	  		}

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        // jumpSound.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
			if (CameraChange.CamMode == 0){
				if (collision.gameObject.CompareTag("Button"))
        {
            // Destroy(collision.transform.parent.gameObject);
				rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 5f);
				rb.transform.Translate(0,0,zTranslation1);
				// rb.transform.Translate(0,0,27.5f);
        }

				if (collision.gameObject.CompareTag("Button 2"))
        {
				rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 5f);
				rb.transform.Translate(0,0,zTranslation2);
        }

				if (collision.gameObject.CompareTag("Button 3"))
        {
				rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 5f);
				rb.transform.Translate(0,0,zTranslation3);
        }

				if (collision.gameObject.CompareTag("Button 4"))
        {
				rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 5f);
				rb.transform.Translate(0,0,zTranslation4);
        }
			}
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
}
