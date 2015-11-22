using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleScreenGUI : MonoBehaviour 
{
	public float textFadeSpeed;
	public float textFade;
	public float titleSpeed;

	public bool isFading;
	public bool titleMoving;

	public Text pressAnyButton;

	public Image title;

	// Use this for initialization
	void Start () 
	{
		titleMoving = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		PressAnyButton ();
		TitleMovement ();
	}
	void PressAnyButton ()
	{
		if (Input.anyKey)
		{
			Application.LoadLevel (1);
		}
		pressAnyButton.color = new Color (1,0,0,textFade);
		if (isFading == false) 
		{
			textFade += textFadeSpeed;
			if (textFade > 0.90f)
			{
				isFading = true;
			}
		}
		else
		{
			textFade -= textFadeSpeed;
			if (textFade < 0.1f)
			{
				isFading = false;
			}
		}
	}

	void TitleMovement ()
	{
		Vector3 newTitlePosition = new Vector3 (0,title.transform.localPosition.y,title.transform.localPosition.z);
		if (titleMoving == true) 
		{
			title.transform.localPosition = Vector3.Lerp(title.transform.localPosition,newTitlePosition,titleSpeed * Time.deltaTime);
		}
	}
}
