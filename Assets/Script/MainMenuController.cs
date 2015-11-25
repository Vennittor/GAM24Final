using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour 
{
	public float colorChangeSpeed;

	public bool fadeIn;

	public Image background;

	// Use this for initialization
	void Start () 
	{
		fadeIn = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		FadeIn ();
	}

	void FadeIn ()
	{
		if (fadeIn == true) 
		{
			background.color = Color.Lerp (background.color,new Color(1,1,1),colorChangeSpeed);
		}
	}
}
