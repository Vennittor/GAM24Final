using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour 
{
	public Image pOneCharacter;
	public Image pTwoCharacter;
	public Image pThreeCharacter;
	public Image pFourCharacter;

	public Text playerCountText;
	public Text pOneCharacterText;
	public Text pTwoCharacterText;
	public Text pThreeCharacterText;
	public Text pFourCharacterText;

	public Sprite[] characterSprites;

	public enum TurnTracker{playerOne,playerTwo,playerThree,playerFour}

	public TurnTracker playerTurn;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	//Changes the player who is selecting
	public void pOneSelectButton ()
	{
		playerTurn = TurnTracker.playerOne;
	}
	public void pTwoSelectButton ()
	{
		playerTurn = TurnTracker.playerTwo;
	}
	public void pThreeSelectButton ()
	{
		playerTurn = TurnTracker.playerThree;
	}
	public void pFourSelectButton ()
	{
		playerTurn = TurnTracker.playerFour;
	}

	//Selects the character and applies it to correct player
	public void Mario ()
	{
		if (playerTurn == TurnTracker.playerOne)
		{
			pOneCharacter.sprite = characterSprites[0];
			pOneCharacterText.text = "MARIO";
		}
		else if (playerTurn == TurnTracker.playerTwo) 
		{
			pTwoCharacter.sprite = characterSprites[0];
			pTwoCharacterText.text = "MARIO";
		}
		else if (playerTurn == TurnTracker.playerThree) 
		{
			pThreeCharacter.sprite = characterSprites[0];
			pThreeCharacterText.text = "MARIO";
		}
		else if (playerTurn == TurnTracker.playerFour) 
		{
			pFourCharacter.sprite = characterSprites[0];
			pFourCharacterText.text = "MARIO";
		}
	}
	public void DonkeyKong ()
	{
		if (playerTurn == TurnTracker.playerOne)
		{
			pOneCharacter.sprite = characterSprites[1];
			pOneCharacterText.text = "DONKEY KONG";
		}
		else if (playerTurn == TurnTracker.playerTwo) 
		{
			pTwoCharacter.sprite = characterSprites[1];
			pTwoCharacterText.text = "DONKEY KONG";
		}
		else if (playerTurn == TurnTracker.playerThree) 
		{
			pThreeCharacter.sprite = characterSprites[1];
			pThreeCharacterText.text = "DONKEY KONG";
		}
		else if (playerTurn == TurnTracker.playerFour) 
		{
			pFourCharacter.sprite = characterSprites[1];
			pFourCharacterText.text = "DONKEY KONG";
		}
	}
	public void Samus ()
	{
		if (playerTurn == TurnTracker.playerOne)
		{
			pOneCharacter.sprite = characterSprites[2];
			pOneCharacterText.text = "SAMUS";
		}
		else if (playerTurn == TurnTracker.playerTwo) 
		{
			pTwoCharacter.sprite = characterSprites[2];
			pTwoCharacterText.text = "SAMUS";
		}
		else if (playerTurn == TurnTracker.playerThree) 
		{
			pThreeCharacter.sprite = characterSprites[2];
			pThreeCharacterText.text = "SAMUS";
		}
		else if (playerTurn == TurnTracker.playerFour) 
		{
			pFourCharacter.sprite = characterSprites[2];
			pFourCharacterText.text = "SAMUS";
		}
	}
	public void Kirby ()
	{
		if (playerTurn == TurnTracker.playerOne)
		{
			pOneCharacter.sprite = characterSprites[3];
			pOneCharacterText.text = "KIRBY";
		}
		else if (playerTurn == TurnTracker.playerTwo) 
		{
			pTwoCharacter.sprite = characterSprites[3];
			pTwoCharacterText.text = "KIRBY";
		}
		else if (playerTurn == TurnTracker.playerThree) 
		{
			pThreeCharacter.sprite = characterSprites[3];
			pThreeCharacterText.text = "KIRBY";
		}
		else if (playerTurn == TurnTracker.playerFour) 
		{
			pFourCharacter.sprite = characterSprites[3];
			pFourCharacterText.text = "KIRBY";
		}
	}
	public void Luigi ()
	{
		if (playerTurn == TurnTracker.playerOne)
		{
			pOneCharacter.sprite = characterSprites[4];
			pOneCharacterText.text = "LUIGI";
		}
		else if (playerTurn == TurnTracker.playerTwo) 
		{
			pTwoCharacter.sprite = characterSprites[4];
			pTwoCharacterText.text = "LUIGI";
		}
		else if (playerTurn == TurnTracker.playerThree) 
		{
			pThreeCharacter.sprite = characterSprites[4];
			pThreeCharacterText.text = "LUIGI";
		}
		else if (playerTurn == TurnTracker.playerFour) 
		{
			pFourCharacter.sprite = characterSprites[4];
			pFourCharacterText.text = "LUIGI";
		}
	}
	public void Zelda ()
	{
		if (playerTurn == TurnTracker.playerOne)
		{
			pOneCharacter.sprite = characterSprites[5];
			pOneCharacterText.text = "ZELDA";
		}
		else if (playerTurn == TurnTracker.playerTwo) 
		{
			pTwoCharacter.sprite = characterSprites[5];
			pTwoCharacterText.text = "ZELDA";
		}
		else if (playerTurn == TurnTracker.playerThree) 
		{
			pThreeCharacter.sprite = characterSprites[5];
			pThreeCharacterText.text = "ZELDA";
		}
		else if (playerTurn == TurnTracker.playerFour) 
		{
			pFourCharacter.sprite = characterSprites[5];
			pFourCharacterText.text = "ZELDA";
		}
	}
	public void Yoshi ()
	{
		if (playerTurn == TurnTracker.playerOne)
		{
			pOneCharacter.sprite = characterSprites[6];
			pOneCharacterText.text = "YOSHI";
		}
		else if (playerTurn == TurnTracker.playerTwo) 
		{
			pTwoCharacter.sprite = characterSprites[6];
			pTwoCharacterText.text = "YOSHI";
		}
		else if (playerTurn == TurnTracker.playerThree) 
		{
			pThreeCharacter.sprite = characterSprites[6];
			pThreeCharacterText.text = "YOSHI";
		}
		else if (playerTurn == TurnTracker.playerFour) 
		{
			pFourCharacter.sprite = characterSprites[6];
			pFourCharacterText.text = "YOSHI";
		}
	}
	public void Bowser ()
	{
		if (playerTurn == TurnTracker.playerOne)
		{
			pOneCharacter.sprite = characterSprites[7];
			pOneCharacterText.text = "BOWSER";
		}
		else if (playerTurn == TurnTracker.playerTwo) 
		{
			pTwoCharacter.sprite = characterSprites[7];
			pTwoCharacterText.text = "BOWSER";
		}
		else if (playerTurn == TurnTracker.playerThree) 
		{
			pThreeCharacter.sprite = characterSprites[7];
			pThreeCharacterText.text = "BOWSER";
		}
		else if (playerTurn == TurnTracker.playerFour) 
		{
			pFourCharacter.sprite = characterSprites[7];
			pFourCharacterText.text = "BOWSER";
		}
	}
}







