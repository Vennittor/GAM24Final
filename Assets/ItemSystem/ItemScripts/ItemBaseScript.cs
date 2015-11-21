using UnityEngine;
using System.Collections;

public class ItemBaseScript : MonoBehaviour 
{
	public bool held = false;
	public bool thrown = false;

	public float damage;
	public float thrownDMG;
	public float durability;

	public Rigidbody rb;

	GameObject owner;
	// Use this for initialization
	public virtual void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	public virtual void Grabbed()
	{
		held = true;
		owner = transform.parent.gameObject;
	}
	public virtual void Released()
	{
		thrown = true;
		held = false;
	}
	public virtual void FunctionAlpha()
	{

	}
	public virtual void FunctionBeta()
	{
		
	}

}
	

