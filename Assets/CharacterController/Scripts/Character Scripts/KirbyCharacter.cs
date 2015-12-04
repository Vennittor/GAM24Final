using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KirbyCharacter : BaseCharacter 
{
	public override void Awake () 
	{
		playerStates = this.gameObject.GetComponent<PlayerStates> ();
		disabledStates = this.gameObject.GetComponent<DisabledStates> ();
		inputManager = this.gameObject.GetComponent<CharacterInputManager> ();
		rigidBody = this.gameObject.GetComponent<Rigidbody> ();
		Physics.IgnoreCollision (this.gameObject.GetComponent<Collider> (), hitCollider.GetComponent<Collider> ());
		hitCollider.SetActive (false);
		hitCollider.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		weight = 1f;
		speed = 20.0f;
		health = 0;
		jumpHeight = 10f;
		jumpMax = 5;
		attackCount = 0;

		//bool hasItem;
	}
	public override void Update ()
	{
		time = 0;
		if (smashTime != null)
		{
			time = smashTime.currentTime / smashTime.targetTime;
			smashBar.transform.localScale = new Vector3(time, smashBar.transform.localScale.z, smashBar.transform.localScale.z);
		}
	}

	public override void StandingA()
	{
		float attackLegnth = 0.1f;
		Vector3 boxCollider = new Vector3 (0.5f, 0.5f, 0.5f);
		Vector3 position = new Vector3 (1f, 0f, 0f);
		Vector3 lerpVelocity = Vector3.zero;
		float lerpSpeed = 0f;
		bool pivot = false;
		Vector3 rotationDirection = Vector3.zero;
		float rotationSpeed = 0.0f;
		
		StartCoroutine (attackMovement (attackLegnth, boxCollider, position, lerpVelocity, lerpSpeed, pivot, rotationDirection, rotationSpeed));
		// Neutral Standing A Animation
		// Neutral Standing A Sound 
	}
	public override void ComboA()
	{
		if (!started)
		{
			attackCount = 0;
			comboTime = new Timer (0.5f);
			started = true;
		}
		else
		{
			attackCount++;
			if (attackCount >= 2)
			{
				comboTime.Pause();
				float attackLegnth = 10f;
				Vector3 boxCollider = new Vector3 (0.5f, 0.5f, 0.5f);
				Vector3 position = new Vector3 (1f, 0f, 0f);
				Vector3 lerpVelocity = Vector3.zero;
				float lerpSpeed = 0f;
				bool pivot = false;
				Vector3 rotationDirection = Vector3.zero;
				float rotationSpeed = 0.0f;
				
				StartCoroutine (comboAttack (attackLegnth, boxCollider, position, lerpVelocity, lerpSpeed, pivot, rotationDirection, rotationSpeed));
			}
			else
				StandingA();
		}
		comboTime.timerComplete += () => {started = false; if (attackCount >=2) comboEnd (); attackCount = 0; };
	}
	public void comboEnd()
	{
		float attackLegnth = 0.15f;
		Vector3 boxCollider = new Vector3 (0.5f, 0.5f, 0.5f);
		Vector3 position = new Vector3 (1f, 0f, 0f);
		Vector3 lerpVelocity = Vector3.zero;
		float lerpSpeed = 0f;
		bool pivot = true;
		Vector3 rotationDirection = Vector3.forward;
		float rotationSpeed = 500.0f;
		
		StartCoroutine (attackMovement (attackLegnth, boxCollider, position, lerpVelocity, lerpSpeed, pivot, rotationDirection, rotationSpeed));
	}
	public override void LeftRightA()
	{
		print ("Kirby LeftRight A was called");
	}
	public override void DownA()
	{
		print ("Kirby Down A was called");
	}
	public override void UpA()
	{
		print ("Kirby Up A was called");
	}
	public override void SprintA()
	{
		float attackLegnth = 0.7f;
		Vector3 boxCollider = new Vector3 (3f, 1f, 0.2f);
		Vector3 position = new Vector3 (0f, 1f, 0f);
		Vector3 lerpVelocity = new Vector3 (rigidBody.velocity.x * 2, 0f, 0f);
		float lerpSpeed = 1.0f;
		bool pivot = false;
		Vector3 rotationDirection = Vector3.up;
		float rotationSpeed = 1500.0f;

		StartCoroutine (attackMovement (attackLegnth, boxCollider, position, lerpVelocity, lerpSpeed, pivot, rotationDirection, rotationSpeed));
		// Kirby Dashing A Animation
		// Kirby Dashing A Sound
	}
	public override void NeutralAAir()
	{
		float attackLegnth = 0.5f;
		Vector3 boxCollider = new Vector3 (3.0f, 3.0f, 0.2f);
		Vector3 position = Vector3.zero;
		Vector3 lerpVelocity = Vector3.zero;
		float lerpSpeed = 0f;
		bool pivot = false;
		Vector3 rotationDirection = Vector3.forward;
		float rotationSpeed = 1250.0f;

		StartCoroutine (attackMovement (attackLegnth, boxCollider, position, lerpVelocity, lerpSpeed, pivot, rotationDirection, rotationSpeed));
		// Neutral A Air Animation
		// Neutral A Air Sound 
	}
	public override void UpAir()
	{
		float attackLegnth = 0.2f;
		Vector3 boxCollider = new Vector3 (3.0f, 0.4f, 0.1f);
		Vector3 position = new Vector3 (1.0f, -0.5f, 0f);
		Vector3 lerpVelocity = Vector3.zero;
		float lerpSpeed = 0f;
		bool pivot = true;
		Vector3 rotationDirection = Vector3.forward;
		float rotationSpeed = 1200.0f;

		StartCoroutine (attackMovement (attackLegnth, boxCollider, position, lerpVelocity, lerpSpeed, pivot, rotationDirection, rotationSpeed));
		// Up Air Animation
		// Up Air Sound
	}
	public override void DownAir()
	{
		print ("Kirby Down Air was called");
		// Down Air Animation
		// Down Air Sound
	}
	public override void LeftRightAir()
	{
		print ("Kirby Left Air was called");
		// Left Air Animation
		// Left Air Sound
	}
	public override void UpSmashA()
	{
		smashTime = new Timer (1.2f);
		started = true;
		StartCoroutine(smashAttack());
		smashTime.timerComplete += () => started = false;;
	}
	public override void DownSmashA()
	{
		print ("Kirby Smash A Down was called");
		// Down A Smash Animarion 
		// Down A Smash Sound 
	}
	public override void LeftRightSmashA()
	{
		print ("Kirby Smash A LeftRight was called");
		// Left A Smash Animarion 
		// Left A Smash Sound 
	}
	public override void NeutralB()
	{
		print ("Kerby Neutral B was called");
		// Neutral B Animation
		// Neutral B Sound
	}
	public override void UpSpecialB()
	{
		print ("Kirby Special B Up was called");
		// Up B Special Animarion 
		// Up B Special Sound 
	}
	public override void DownSpecialB()
	{
		print ("Kirby Special B Down was called");
		// Down B Special Animarion 
		// Down B Special Sound 
	}
	public override void LeftRightSpecialB()
	{
		print ("Kirby Special B LeftRight was called");
		// Left B Special Animarion 
		// Left B Special Sound 
	}
	public override void AGrab()
	{
		print ("Kirby A Grab was called");
		// A Grab Animation
		// A Grab Sound
	}
	public override void UpThrow()
	{
		print ("Kirby Up Throw was called");
		// Up Throw Animation
		// Up Throw Sound 
	}
	public override void DownThrow()
	{
		print ("Kirby Down Throw was called");
		// Down Throw Animation
		// Down Throw Sound 
	}
	public override void LeftRightThrow()
	{
		print ("Kirby LeftRight Throw was called");
		// Left Throw Animation
		// Left Throw Sound 
	}
	public override void LedgeAttack()
	{
		print ("Kirby Ledge Attack was called");
		// Ledge Attack Animation
		// Ledge Attack Sound
	}
	
	public override IEnumerator attackMovement(float attackLength, Vector3 boxCollider, Vector3 position, Vector3 lerpVelocity, float lerpSpeed, 
	                                  bool pivot, Vector3 rotationDirection, float rotationSpeed)
	{
		playerStates.disabledStates.Add(PlayerStates.disabledAndProtectiveStates.ABILITYLOCK);
		hitCollider.SetActive (true);

		while (playerStates.disabledStates.Contains(PlayerStates.disabledAndProtectiveStates.ABILITYLOCK))
		{
			disabledStates.vAttackLength = attackLength;

			hitCollider.transform.localPosition = position;
			hitCollider.transform.localScale = boxCollider;

			rigidBody.velocity = Vector3.Lerp (this.rigidBody.velocity, lerpVelocity, lerpSpeed * Time.deltaTime);

			if (pivot)
				parent.transform.Rotate(rotationDirection, rotationSpeed * Time.deltaTime);
			else
				hitCollider.transform.Rotate(rotationDirection, rotationSpeed * Time.deltaTime);

			yield return null;
		}
	}

	public override void ResetAttack()
	{
		if (playerStates.disabledStates.Contains(PlayerStates.disabledAndProtectiveStates.ABILITYLOCK))
			playerStates.disabledStates.Remove (PlayerStates.disabledAndProtectiveStates.ABILITYLOCK);
		
		if (parent != null)
		{
			parent.transform.localPosition = Vector3.zero;
			parent.transform.localRotation = Quaternion.identity;
		}
		hitCollider.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		hitCollider.transform.localPosition = Vector3.zero;
		hitCollider.SetActive (false);
		hitCollider.transform.localRotation = Quaternion.identity;
	}

	public override IEnumerator comboAttack (float attackLength, Vector3 boxCollider, Vector3 position, Vector3 lerpVelocity, float lerpSpeed, bool pivot, Vector3 rotationDirection, float rotationSpeed)
	{
		hitCollider.SetActive (true);

		while (Input.GetButton(inputManager.playerName + "_Attack"))
		{
			inputManager.leftInput = inputManager.rightInput = inputManager.downInput = inputManager.upInput = 0f;
			inputManager.attackButton = inputManager.grabButton = inputManager.jumpButton = inputManager.shieldButton = inputManager.specialButton = false;

			disabledStates.vAttackLength = attackLength;
			
			hitCollider.transform.localPosition = new Vector3 (1f, Random.Range(-1f, 1f), 0f);
			hitCollider.transform.localScale = boxCollider;
			
			rigidBody.velocity = Vector3.Lerp (this.rigidBody.velocity, lerpVelocity, lerpSpeed * Time.deltaTime);
			
			if (pivot)
				parent.transform.Rotate(rotationDirection, rotationSpeed * Time.deltaTime);
			else
				hitCollider.transform.Rotate(rotationDirection, rotationSpeed * Time.deltaTime);
			
			yield return null;
		}
		ResetAttack ();
		comboTime.Kill ();
	}

	public override IEnumerator smashAttack ()
	{
		while(Input.GetButton(inputManager.playerName + "_Attack"))
		{
			inputManager.leftInput = inputManager.rightInput = inputManager.downInput = inputManager.upInput = 0f;
			inputManager.attackButton = inputManager.grabButton = inputManager.jumpButton = inputManager.shieldButton = inputManager.specialButton = inputManager.spamButton = false;

			yield return null;
		}

		smashTime.Kill ();
	}
}



















