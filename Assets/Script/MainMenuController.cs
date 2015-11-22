using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour 
{
	public float colorChangeSpeed;

	public Image background;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Background ();
	}

	void Background ()
	{
		background.color = Color.Lerp (background.color,new Color(0.9f,0.9f,0.9f),colorChangeSpeed);
	}
}
