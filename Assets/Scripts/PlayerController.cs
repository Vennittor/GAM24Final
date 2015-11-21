using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(Rigidbody))]
public class PlayerController : MonoBehaviour 
{
	public float health;
	public Sprite characterPortrate; 
	public int speed = 2; 
	public float force = 400.0f;
	public bool shieldIsActive; 
	public GameObject shield = null;
	public float shieldDegen = 8f;

	//better variables
	public bool grounded;
	public bool justJumped;
	public bool jump1;
	public bool jump2; 

	Rigidbody rigidBody;
	Vector3 tempShieldScale;
	float jumpHeight = 2.5f;
	float gravity = 10.0f;
	float maxVelocityChange = 10.0f;

	void Awake()
	{
		rigidBody = GetComponent<Rigidbody> ();
		rigidBody.freezeRotation = true;
		rigidBody.useGravity = false;
	}
	// Use this for initialization
	void Start ()
	{
		//rb = GetComponent<Rigidbody> ();
		jump1 = false; 
		jump2 = false; 
		shieldIsActive = false; 
		tempShieldScale = shield.GetComponent<Transform> ().localScale;
		shield.GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
//	void Update ()
//	{
//
//		if (Input.GetKey (KeyCode.LeftShift)) 
//		{
//			shield.GetComponent<MeshRenderer>().enabled = true;
//			shieldIsActive = true; 
//			shield.GetComponent<Transform>().localScale = Vector3.Lerp(shield.GetComponent<Transform>().localScale, Vector3.zero, shieldDegen * Time.deltaTime);
//		}
//		if (Input.GetKeyUp (KeyCode.LeftShift)) 
//		{
//			shield.GetComponent<MeshRenderer>().enabled = false;
//			shieldIsActive = false;
//		}
//		if (Input.GetKeyUp (KeyCode.S)) 
//		{
//
//		}
//
//		if (!shieldIsActive)
//			shield.GetComponent<Transform>().localScale = Vector3.Lerp(shield.GetComponent<Transform>().localScale, tempShieldTrans, shieldDegen * Time.deltaTime);
//	}

	void FixedUpdate()
	{
		if (!grounded) 
		{
			jump1 = true; 
		}
		MoveCharacter ();
//		if (Input.GetKeyDown (KeyCode.W) && jump1 == false && !shieldIsActive) 
//		{
//			rb.AddForce (transform.up * force);
//			jump1 = true;
//		}
//		else if(Input.GetKeyDown (KeyCode.W)&& jump1 == true && jump2 == false && !shieldIsActive) 
//		{
//			rb.AddForce (transform.up * force);
//			jump1 = true; 
//			jump2 = true;
//		}
	}

	void MoveCharacter()
	{
		if (grounded)
		{
			Vector3 targetVelocity = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
			targetVelocity = transform.TransformDirection(targetVelocity);
			targetVelocity *= speed;

			Vector3 velocity = rigidBody.velocity;
			Vector3 velocityChange = (targetVelocity - velocity);
			velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
			velocityChange.y = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
			velocityChange.z = 0;
			rigidBody.AddForce(velocityChange, ForceMode.Impulse);
		}

		if (Input.GetButtonDown("Jump") && jump1 && !jump2)
		{
			rigidBody.velocity = new Vector3(rigidBody.velocity.x, CalculateJumpVelocity(), 0);
			jump2 = true;

			Vector3 targetVelocity = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
			targetVelocity = transform.TransformDirection(targetVelocity);
			targetVelocity *= speed;
			
			Vector3 velocity = rigidBody.velocity;
			Vector3 velocityChange = (targetVelocity - velocity);
			velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
			velocityChange.y = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
			velocityChange.z = 0;
			rigidBody.AddForce(velocityChange, ForceMode.Impulse);
		}
		if (Input.GetButtonDown("Jump") && !jump1 && !jump2)
		{
			rigidBody.velocity = new Vector3(rigidBody.velocity.x, CalculateJumpVelocity(), 0);
			jump1 = true;
		}

		rigidBody.AddForce (new Vector3 (0, -gravity * rigidBody.mass, 0));

		grounded = false;
	}
	
	float CalculateJumpVelocity()
	{
		return Mathf.Sqrt (2 * jumpHeight * gravity);
	}

	public void TakeDamage(int damage)
	{
		health -= damage;
	}
}

