using UnityEngine;
using System.Collections;


//RENAME TO CHARACTERINPUTMANAGER
public class PlayerMovement : MonoBehaviour 
{
	PlayerStates states;
	public float grabRange = 1.0f;

	void Awake()
	{
		states = this.GetComponent<PlayerStates> ();
	}

	public bool CheckGrab()
	{
		RaycastHit hit;
		
		Debug.DrawRay (transform.position, grabRange * Vector3.right, Color.red);
		if (Physics.Raycast(transform.position, Vector3.right, out hit, grabRange))
		{
			if (hit.collider.tag == "Player")
				return true;
			else
				return false;
		}
		return false;
	}
}
