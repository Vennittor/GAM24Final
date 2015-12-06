using UnityEngine;
using System.Collections;

public class Animator_Controller : MonoBehaviour {

	
	Animator anim;
	
	int attack_Hash = Animator.StringToHash("attack");
	int up_Hash = Animator.StringToHash("up");
	int down_Hash = Animator.StringToHash("down");
	int forward_Hash = Animator.StringToHash("forward");
	int back_Hash = Animator.StringToHash("back");
	
	int runStateHash = Animator.StringToHash("Running");
	int attackDStateHash = Animator.StringToHash("Base Layer.Dash_Attack");
	
	AnimatorStateInfo stateInfo;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//SKYLAR & RORY
		//THESE ARE THE EXAMPLES OF HOW TO USE METHODS 
		//YOU WILL CALL IN YOUR CHARACTER CONTROLLER

		stateInfo = anim.GetCurrentAnimatorStateInfo(0);
	
		if (Input.GetKey (KeyCode.LeftArrow)||Input.GetKey (KeyCode.RightArrow)) {
			runSpeed(1);
		} else {
			runSpeed(0);
		}
		
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			doAttack();
		}
		
		if (Input.GetKey (KeyCode.UpArrow)) 
			holdUp(true);
		else 
			holdUp(false);

		if (Input.GetKey (KeyCode.DownArrow))
			holdDown(true);
		else 
			holdDown(false);

	}



	public void holdUp(bool boo)
	{
		anim.SetBool (up_Hash, boo);
	}

	public void holdDown(bool boo)
	{
		anim.SetBool (down_Hash,boo);
	}
	
	public void doAttack()
	{
		anim.SetTrigger (attack_Hash);
	}
	
	public void runSpeed(int inSpeed)
	{
		anim.SetFloat ("speed", inSpeed);
	}
}
