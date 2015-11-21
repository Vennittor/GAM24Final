using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour 
{
	public GameObject player = null;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Ground") 
		{
			player.GetComponent<PlayerController>().jump1 = false; 
			player.GetComponent<PlayerController>().jump2 = false; 
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Ground")
		{
			player.GetComponent<PlayerController>().grounded = true;
			player.GetComponent<PlayerController>().justJumped = true;
		}
	}
}
