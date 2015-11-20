using UnityEngine;
using System.Collections;

public class ItemBaseScript : MonoBehaviour 
{
	public bool held = false;
	public bool thrown = false;
	public float damage;
	public float durability;

	// Use this for initialization

	public void Grabbed()
	{
		held = true;
	}
	public void Released()
	{
		held = false;
	}
	public virtual void FunctionAlpha()
	{

	}
	public virtual void FunctionBeta()
	{
		
	}

}
	

