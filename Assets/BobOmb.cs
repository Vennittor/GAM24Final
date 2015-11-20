using UnityEngine;
using System.Collections;

public class BobOmb : ItemBaseScript 
{
	public float timer;
	public int radius;
	public GameObject bobOmb;
	public int damage = 50;
	public bool faceright = true;
	public bool called = false;
	
	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		timer = timer * Time.deltaTime;

		if (timer >= 8.0f && !held && thrown == false) 
		{
			int scott = Random.Range (0, 2);
			
			if (scott == 1) 
			{
				faceright = true;
			} 
			else 
			{
				faceright = false;
			}
			
			if (faceright)
			{
				transform.Translate (Vector3.right);
			}
			else
			{
				transform.Translate (Vector3.left);
			}
			thrown = true;
		}
	}

	public override void FunctionAlpha()
	{
		GameObject.FindGameObjectsWithTag ("Player");
		if (held == true) 
		{
			//player becomes parent
			GameObject thrower = transform.parent.gameObject;
		}
	}

	public override void FunctionBeta()
	{
		Collider[] hitColliders = Physics.OverlapSphere (transform.position, radius);
		foreach (Collider b in hitColliders) 
		{
			if (b.gameObject.tag == "Player")
			{
				//this.gameObject.GetComponent<PlayerController>.TakeDamage(damage);
			}
			else
			{
				//this.gameobject.GetComponent<Enemy>.TakeDamage(damage);
			}
		}
	}

	public void OnCollisionEnter(Collision other)
	{
		if (thrown == true) 
		{
			FunctionBeta();
		}
		else
		{

		}
	}
}
