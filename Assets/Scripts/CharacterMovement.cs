//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;
//
//[RequireComponent (typeof(Rigidbody))]
//public class CharacterMovement : MonoBehaviour 
//{
//	public bool shieldIsActive; 
//	public GameObject shield = null;
//	public float shieldDegen = 8f;
//	public int jumpMax = 5;
//
//	int jumpCount = 5;
//	float sprintInput = 0;
//	float jumpHeight = 1f;
//	float gravity = 10.0f;
//	float maxVelocityChange = 10.0f;
//
//	bool grounded;
//	string player; 
//	Rigidbody rigidBody;
//	Vector3 startShieldSize;
//	PlayerStates states;
//
//	void Awake()
//	{
//		rigidBody = GetComponent<Rigidbody> ();
//		rigidBody.freezeRotation = true;
//		rigidBody.useGravity = false;
//	}
//	// Use this for initialization
//	void Start ()
//	{
//		player = this.name.ToString ();
//
//		states = this.gameObject.GetComponent<PlayerStates>();
//		startShieldSize = shield.GetComponent<Transform> ().localScale;
//		shield.GetComponent<MeshRenderer>().enabled = false;
//	}
//	
//	// Update is called once per frame
//	void Update ()
//	{
//		if (Input.GetButton(player + "_Shield"))
//		{
//			shield.GetComponent<MeshRenderer>().enabled = true;
//			shieldIsActive = true; 
//			shield.GetComponent<Transform>().localScale = Vector3.Lerp(shield.GetComponent<Transform>().localScale, Vector3.zero, shieldDegen * Time.deltaTime);
//		}
//		if (Input.GetButtonUp (player + "_Shield"))
//		{
//			shield.GetComponent<MeshRenderer>().enabled = false;
//			shieldIsActive = false;
//		}
//		if (!shieldIsActive)
//			shield.GetComponent<Transform>().localScale = Vector3.Lerp(shield.GetComponent<Transform>().localScale, startShieldSize, shieldDegen * Time.deltaTime);
//	}
//
//	void FixedUpdate()
//	{
//		CheckGround ();
//		StateHandler ();
//		MoveCharacter ();
//	}
//
//	void MoveCharacter()
//	{
////		if (states.state == PlayerStates.State.gSprint || states.state == PlayerStates.State.gWalk || states.state == PlayerStates.State.gStand)
////		{
////			Vector3 targetVelocity = new Vector3 (Input.GetAxis(player + "_Horizontal"), Input.GetAxis(player + "_Vertical"),0);
////			targetVelocity = transform.TransformDirection(targetVelocity);
////			targetVelocity *= states.speed;
////
////			Vector3 velocity = rigidBody.velocity;
////			Vector3 velocityChange = (targetVelocity - velocity);
////			velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
////			velocityChange.y = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
////			velocityChange.z = 0;
////			rigidBody.AddForce(velocityChange, ForceMode.Impulse);
////		}
//
//		if (Input.GetButtonDown(player + "_Jump") && jumpCount > 0)
//		{
//			jumpCount--;
//			rigidBody.velocity = new Vector3(rigidBody.velocity.x / 10, CalculateJumpVelocity(), 0);
//
//			Vector3 targetVelocity = new Vector3 (Input.GetAxis(player + "_Horizontal"), CalculateJumpVelocity(),0);
//			targetVelocity = transform.TransformDirection(targetVelocity);
//			targetVelocity *= states.speed;
//			
//			Vector3 velocity = rigidBody.velocity;
//			Vector3 velocityChange = (targetVelocity - velocity);
//			velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
//			velocityChange.y = Mathf.Clamp(velocityChange.y, -maxVelocityChange, maxVelocityChange);
//			velocityChange.z = 0;
//			rigidBody.AddForce (velocityChange, ForceMode.Impulse);
//		}
//
//		rigidBody.AddForce (new Vector3 (0, -gravity * rigidBody.mass, 0));
//
//		grounded = false;
//	}
//	
//	float CalculateJumpVelocity()
//	{
//		if (jumpCount == jumpMax-1)
//			return Mathf.Sqrt (2 * jumpHeight * gravity) + (jumpCount - (jumpMax+1));
//		else
//			return Mathf.Sqrt (2 * jumpHeight * gravity) + (jumpCount - (jumpMax-1));
//	}
//
//	void CheckGround()
//	{
//		RaycastHit hit;
//
//		Debug.DrawRay (transform.position, 0.5f * Vector3.down, Color.green);
//		if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
//		{
//			if (hit.collider.tag == "Ground")
//			{
//				grounded = true;
//				jumpCount = jumpMax;
//			}
//		}
//	}
//
//	void StateHandler()
//	{
////		if (grounded)
////		{
////			float tempInput = sprintInput;
////			sprintInput = Input.GetAxis(player + "_Horizontal");
////
////			if (Mathf.Abs(sprintInput) - Mathf.Abs(tempInput) > 0.32f)
////				states.state = PlayerStates.State.gSprint;
////			else if (Mathf.Abs(sprintInput) == 0)
////				states.state = PlayerStates.State.gStand;
////			else if (rigidBody.velocity.magnitude > 0f && states.state != PlayerStates.State.gSprint)
////				states.state = PlayerStates.State.gWalk;
////		}
////		else
////		{
////			states.state = PlayerStates.State.aAir;
////		}
//	}
//}
//
