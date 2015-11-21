using UnityEngine;
using System.Collections;

public class Pill : ItemBaseScript 
{

	public override void FunctionAlpha ()
	{
		//addforc in thrown direction
		thrown = true;

		base.FunctionAlpha ();
	}
	void OnCollisionEnter(Collision other)
	{
		//if(hit by attack)
		//if()

	}
}
