using UnityEngine;
using System.Collections;

public class PlayerStates : MonoBehaviour 
{
	/*
	 *	=== Ground States ===
	 *	-Stand Still
	 *	-Walking
	 *	-Sprinting
	 *	-Being Grabbed
	 *	-Lying Down
	 *	-Grabbing
	 *	-Item Held standing
	 *	-Item Held Walking
	 *	-Item Held Sprinting
	 *	-Flinching
	 *	-Grounded
	 *
	 *	=== Air States ===
	 * 	-Helpless
	 * 	
	 * 
	 * 
	 * 	=== Shielded State === not any more
	 * 
	 *  === Tumble States === ????
	 */
	public float speed;
	public PlayerMovement pMovement;
	Job gStand;
	string player;
	float walkSpeed = 10.0f;
	float sprintSpeed = 15.0f;
	bool grounded;
	float sprintInput;

	public enum State
	{
		//ground states start with a g
		gStand, gWalk, gSprint, gGrabbed, gGrabbing, gLying, gHeldItemStand, gHeldItemWalk, gHeldItemSprint, gFlinch, gGrounded,
		aAir
		//green, yellow, red, 
	}
	[ReadOnlyAttribute][SerializeField] private State vState;
	public State state
	{
		get
		{
			return vState;
		}
		set
		{
			ExitState(vState);
			vState = value;
			EnterState(vState);
		}
	}

	void Awake()
	{
		state = State.gStand;
		pMovement = this.GetComponent<PlayerMovement> ();
		player = this.name;
		sprintInput = 0;
	}

	void FixedUpdate()
	{
		CheckGround ();
	}

	void CheckGround()
	{
		RaycastHit hit;
		
		Debug.DrawRay (transform.position, 0.5f * Vector3.down, Color.green);
		if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
		{
			if (hit.collider.tag == "Ground")
			{
				grounded = true;
			}
		}
	}

	void EnterState (State stateEntered)
	{
		switch (stateEntered)
		{
		case State.gStand:
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
			Job gStand = new Job(groundStand(
				()=>{state = State.gWalk;}, 
				()=>{state = State.aAir;},
			    ()=>{state = State.gSprint;},
				()=>{state = State.gGrabbing;}), true);

			break;

		case State.gWalk:
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
			speed = walkSpeed;

			break;

		case State.gSprint:
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
			speed = sprintSpeed;
			
			break;

		case State.gGrabbing:
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;

			break;

		case State.aAir:
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
			
			break;
		}
	}

	void ExitState (State stateExited)
	{
		switch(stateExited)
		{
		case State.gStand:
			if (gStand != null) gStand.kill();
			break;
		case State.gWalk:
			break;
		case State.gSprint:
			break;
		case State.aAir:
			break;
		}
	}

	IEnumerator groundStand(System.Action changeToGWalk, System.Action changeToAAir, System.Action changeToGSprint, System.Action changeToGGrabbing)
	{
		while (state == State.gStand)
		{
			float tempInput = sprintInput;
			sprintInput = Input.GetAxis(player + "_Horizontal");
			if (Input.GetButtonDown(player + "_Grab"))
			{	
				if(pMovement.CheckGrab())
				{
					changeToGGrabbing();
				}
			}
			if (Mathf.Abs(sprintInput) - Mathf.Abs(tempInput) > 0.1f && grounded)
			{
				changeToGSprint();
			}
			else if (Mathf.Abs(Input.GetAxis(player + "_Horizontal")) > 0.01f && grounded)
			{
				changeToGWalk();
			}
			else if (!grounded)
			{
				changeToAAir();
			}
			yield return null;
		}
	}
}






















