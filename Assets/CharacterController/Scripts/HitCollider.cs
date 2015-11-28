using UnityEngine;
using System.Collections;

public class HitCollider : MonoBehaviour 
{
	/// hit box is based on a pre-set collider size and transform.Translate path
	/// saved with an enum name (ie IkeUpA = 1) in a dictionary, when called
	/// pass in the enum name and find the data for it
	/// 
	/// if debug is on, draw the mesh and make it the character colour (red, blue, yellow, green)
	/// that the player swinging it is









	public bool hit;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			hit = true;
		}
	}
}