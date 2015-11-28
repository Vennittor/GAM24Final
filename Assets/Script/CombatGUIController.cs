using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CombatGUIController : MonoBehaviour 
 {
	public int playerCount;

	public GameObject playerDataHolder;

	//player one
	public Image pOneCharacterPortrait;
	public Image pOneStockImageOne;
	public Image pOneStockImageTwo;

	public Text pOneName;
	public Text pOnePercentText;

	public float pOneCurrentPercent;

	public GameObject playerOne;
	public GameObject playerOneGUI;

	//player two
	public Image pTwoCharacterPortrait;
	public Image pTwoStockImageOne;
	public Image pTwoStockImageTwo;

	public Text pTwoName;
	public Text pTwoPercentText;

	public float pTwoCurrentPercent;

	public GameObject playerTwo;
	public GameObject playerTwoGUI;

	//player three
	public Image pThreeCharacterPortrait;
	public Image pThreeStockImageOne;
	public Image pThreeStockImageTwo;
	
	public Text pThreeName;
	public Text pThreePercentText;
	
	public float pThreeCurrentPercent;
	
	public GameObject playerThree;
	public GameObject playerThreeGUI;

	//player four
	public Image pFourCharacterPortrait;
	public Image pFourStockImageOne;
	public Image pFourStockImageTwo;
	
	public Text pFourName;
	public Text pFourPercentText;
	
	public float pFourCurrentPercent;
	
	public GameObject playerFour;
	public GameObject playerFourGUI;

	// Use this for initialization
	void Start () 
	{
		playerDataHolder = GameObject.Find ("PlayerDataHolder");
		playerCount = playerDataHolder.GetComponent<PlayerDataHolder>().playerCount;
		playerOne = GameObject.FindGameObjectWithTag ("Player One");
		playerTwo = GameObject.FindGameObjectWithTag ("Player Two");
		playerThree = GameObject.FindGameObjectWithTag ("Player Three");
		playerFour = GameObject.FindGameObjectWithTag ("Player Four");
	}
	
	// Update is called once per frame
	void Update () 
	{
		PlayerOneGUI ();
		PlayerTwoGUI ();
		PlayerThreeGUI ();
		PlayerFourGUI ();
		GUIPositions ();
	}

	void PlayerOneGUI ()
	{
		pOneCurrentPercent = playerOne.GetComponent<PlayerController> ().health;
		pOneName.text = playerDataHolder.GetComponent<PlayerDataHolder>().pOneCharacterName;
		pOneCharacterPortrait.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pOnePortrait;
		pOneStockImageOne.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pOneStock;
		pOneStockImageTwo.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pOneStock;
		pOnePercentText.text = "" + (int)pOneCurrentPercent + "%";

		//Percent Color
		if (playerOne.GetComponent<PlayerController> ().health < 50)
		{
			pOnePercentText.color = new Color (1,1,1);
		}
		if (playerOne.GetComponent<PlayerController> ().health >= 50 && playerOne.GetComponent<PlayerController> ().health < 100)
		{
			pOnePercentText.color = new Color (1,0.35f,0);
		}
		if (playerOne.GetComponent<PlayerController> ().health >= 100 && playerOne.GetComponent<PlayerController> ().health < 150)
		{
			pOnePercentText.color = new Color (1,0,0);
		}
		if (playerOne.GetComponent<PlayerController> ().health >= 150)
		{
			pOnePercentText.color = new Color (0.7f,0,0);
		}
	}

	void PlayerTwoGUI ()
	{ 
		pTwoCurrentPercent = playerTwo.GetComponent<PlayerController> ().health;
		pTwoName.text = playerDataHolder.GetComponent<PlayerDataHolder>().pTwoCharacterName;
		pTwoCharacterPortrait.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pTwoPortrait;
		pTwoStockImageOne.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pTwoStock;
		pTwoStockImageTwo.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pTwoStock;
		pTwoPercentText.text = "" + (int)pOneCurrentPercent + "%";

		if (playerTwo.GetComponent<PlayerController> ().health < 50)
		{
			pTwoPercentText.color = new Color (1,1,1);
		}
		if (playerTwo.GetComponent<PlayerController> ().health >= 50 && playerOne.GetComponent<PlayerController> ().health < 100)
		{
			pTwoPercentText.color = new Color (1,0.2f,0.2f);
		}
		if (playerTwo.GetComponent<PlayerController> ().health >= 100 && playerOne.GetComponent<PlayerController> ().health < 150)
		{
			pTwoPercentText.color = new Color (1,0,0);
		}
		if (playerTwo.GetComponent<PlayerController> ().health >= 150)
		{
			pTwoPercentText.color = new Color (0.7f,0,0);
		}
	}

	void PlayerThreeGUI ()
	{
		if (playerCount > 2) 
		{	
			pThreeCurrentPercent = playerThree.GetComponent<PlayerController> ().health;
			pThreeName.text = playerDataHolder.GetComponent<PlayerDataHolder>().pThreeCharacterName;
			pThreeCharacterPortrait.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pThreePortrait;
			pThreeStockImageOne.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pThreeStock;
			pThreeStockImageTwo.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pThreeStock;
			pThreePercentText.text = "" + (int)pThreeCurrentPercent + "%";
			
			if (playerThree.GetComponent<PlayerController> ().health < 50)
			{
				pThreePercentText.color = new Color (1,1,1);
			}
			if (playerThree.GetComponent<PlayerController> ().health >= 50 && playerOne.GetComponent<PlayerController> ().health < 100)
			{
				pThreePercentText.color = new Color (1,0.2f,0.2f);
			}
			if (playerThree.GetComponent<PlayerController> ().health >= 100 && playerOne.GetComponent<PlayerController> ().health < 150)
			{
				pThreePercentText.color = new Color (1,0,0);
			}
			if (playerThree.GetComponent<PlayerController> ().health >= 150)
			{
				pThreePercentText.color = new Color (0.7f,0,0);
			}
		}
	}
//
	void PlayerFourGUI ()
	{
		if (playerCount > 3) 
		{
			pFourCurrentPercent = playerFour.GetComponent<PlayerController> ().health;
			pFourName.text = playerDataHolder.GetComponent<PlayerDataHolder>().pFourCharacterName;
			pFourCharacterPortrait.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pFourPortrait;
			pFourStockImageOne.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pFourStock;
			pFourStockImageTwo.sprite = playerDataHolder.GetComponent<PlayerDataHolder> ().pFourStock;
			pFourPercentText.text = "" + (int)pFourCurrentPercent + "%";
			
			if (playerFour.GetComponent<PlayerController> ().health < 50)
			{
				pFourPercentText.color = new Color (1,1,1);
			}
			if (playerFour.GetComponent<PlayerController> ().health >= 50 && playerOne.GetComponent<PlayerController> ().health < 100)
			{
				pFourPercentText.color = new Color (1,0.2f,0.2f);
			}
			if (playerFour.GetComponent<PlayerController> ().health >= 100 && playerOne.GetComponent<PlayerController> ().health < 150)
			{
				pFourPercentText.color = new Color (1,0,0);
			}
			if (playerFour.GetComponent<PlayerController> ().health >= 150)
			{
				pFourPercentText.color = new Color (0.7f,0,0);
			}
		}
	}

	void GUIPositions ()
	{
		if (playerCount == 2)
		{
			playerOneGUI.transform.localPosition = new Vector3 (-100, -175, 0);
			playerTwoGUI.transform.localPosition = new Vector3 (100, -175, 0);
			playerThreeGUI.SetActive (false);
			playerFourGUI.SetActive (false);
		} 
		else if (playerCount == 3) 
		{
			playerOneGUI.transform.localPosition = new Vector3(-200,-175,0);
			playerTwoGUI.transform.localPosition = new Vector3(0,-175,0);
			playerThreeGUI.transform.localPosition = new Vector3(200,-175,0);
			playerThreeGUI.SetActive (true);
			playerFourGUI.SetActive (false);
		}
		else if (playerCount == 4)
		{
			playerOneGUI.transform.localPosition = new Vector3(-300,-175,0);
			playerTwoGUI.transform.localPosition = new Vector3(-100,-175,0);
			playerThreeGUI.transform.localPosition = new Vector3(100,-175,0);
			playerFourGUI.transform.localPosition = new Vector3(300,-175,0);
			playerThreeGUI.SetActive (true);
			playerFourGUI.SetActive (true);
		}
	}
}














