using UnityEngine;
using System.Collections;

public class Pill : ItemBaseScript
{


	// Use this for initialization
	void Start () 
	{
		PrintStuff ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	public override void FunctionAlpha()
	{
		base.FunctionAlpha ();
	}
	public override void FunctionBeta()
	{
		
	}














































































	void PrintStuff()
	{
		for(int i = 0; i < 1000000000; i++)
		print("HAHAHAAHAHAHAHAHA");
	}
}