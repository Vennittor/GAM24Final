using UnityEngine;
using System.Collections;

public class Shell : ItemBaseScript 
{
	public float timer =5.0f;
	Vector3 leftright = Vector3.zero;
	public override void Start ()
	{
		base.Start();
	}
	void Update () 
	{
		if(timer>=0)
		timer -= Time.deltaTime;
		if (timer <= 0)
			FunctionBeta ();
	}
	public override void FunctionAlpha ()
	{
		timer = 0;
		base.FunctionAlpha ();
	}
	public override void FunctionBeta ()
	{
		if (leftright == Vector3.zero) 
		{
			int a = Random.Range (0,2);
			if (a==0)
				leftright = new Vector3(-1,0,0);
			else
				leftright = new Vector3(1,0,0);
		}
		rb.AddForce (leftright * 10);
		base.FunctionBeta ();
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name != "Floor") 
		{
			if (other.transform.position.x < gameObject.transform.position.x) {
				leftright = new Vector3 (1, 0, 0);
				//rb.velocity = leftright * 4;
				rb.velocity = leftright * 10;
			} else {
				leftright = new Vector3 (-1, 0, 0);
				//rb.velocity = leftright * 4;
				rb.velocity = leftright * 10;
			}
		}
	}
}
