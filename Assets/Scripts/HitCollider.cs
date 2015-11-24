using UnityEngine;
using System.Collections;

public class HitCollider : MonoBehaviour 
{
	public bool hit;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			hit = true;
		}
	}
}
