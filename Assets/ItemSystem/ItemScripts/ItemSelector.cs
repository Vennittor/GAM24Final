using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class ItemSelector : MonoBehaviour
{
	public enum itemName {FAN, BEAMSWORD, HOMERUNBAT, POKEBALL, BO_OMB,
						ICE, METAL,MUSHROOM,LASERGUN,STAR,SMASHBALL,BUNNYEARS,
						HAMMER,PILL,SHELL,TOMATO,FIREFLOWER,TRIPMINE,BANANAPEEL,
						BUMPER};
	public itemName ItemToSpawn;
	public List<itemName> common;
	public List<itemName> unCommon;
	public List<itemName> rare;
	public List<itemName> veryRare;

	public List<GameObject>itemPrefabs;

	public void RandomDrop()
	{
		if (GetComponent<ItemSpawner>().itemsAwake.Count <= 10) 
		{
			float spawnRoll = Random.Range (0f, 100f);
			if (spawnRoll < 40f) 
			{
				int commonChoice = Random.Range (0, common.Count);
				Spawn (common [commonChoice]);
			} 
			else if (spawnRoll >= 40 && spawnRoll < 70) 
			{
				int commonChoice = Random.Range (0, unCommon.Count);
				Spawn (unCommon [commonChoice]);
			} 
			else if (spawnRoll >= 70 && spawnRoll < 90) 
			{
				int commonChoice = Random.Range (0, rare.Count);
				Spawn (rare [commonChoice]);
			} 
			else if (spawnRoll >= 90) 
			{
				int commonChoice = Random.Range (0, veryRare.Count);
				Spawn (veryRare [commonChoice]);
			}
		}
	}
	public void Spawn(itemName item)
	{
		Debug.Log (item);
		if (item == itemName.BANANAPEEL) 
		{
			GameObject a = Instantiate(itemPrefabs[0],transform.position,Quaternion.Euler(new Vector3(0,90,0)))
				as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.BEAMSWORD) 
		{
			GameObject a = Instantiate(itemPrefabs[1],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}

		else if (item == itemName.BO_OMB)
		{
			GameObject a = Instantiate(itemPrefabs[2],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.BUMPER) 
		{
			GameObject a = Instantiate(itemPrefabs[3],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.BUNNYEARS) 
		{
			GameObject a = Instantiate(itemPrefabs[4],transform.position,Quaternion.identity) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.FAN) 
		{
			GameObject a = Instantiate(itemPrefabs[5],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.FIREFLOWER) {
			GameObject a = Instantiate(itemPrefabs[6],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.HAMMER) 
		{
			GameObject a = Instantiate(itemPrefabs[7],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.HOMERUNBAT) 
		{
			GameObject a = Instantiate(itemPrefabs[8],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.ICE) 
		{
			GameObject a = Instantiate(itemPrefabs[9],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.LASERGUN) {
			GameObject a = Instantiate(itemPrefabs[10],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.METAL) {
			GameObject a = Instantiate(itemPrefabs[11],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.MUSHROOM) {
			GameObject a = Instantiate(itemPrefabs[12],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.PILL) {
			GameObject a = Instantiate(itemPrefabs[13],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.POKEBALL) {
			GameObject a = Instantiate(itemPrefabs[14],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.SHELL) {
			GameObject a = Instantiate(itemPrefabs[15],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.SMASHBALL) 
		{
			GameObject a = Instantiate(itemPrefabs[16],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.STAR) 
		{
			GameObject a = Instantiate(itemPrefabs[17],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.TOMATO) 
		{
			GameObject a = Instantiate(itemPrefabs[18],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
		else if (item == itemName.TRIPMINE) 
		{
			GameObject a = Instantiate(itemPrefabs[19],transform.position,Quaternion.Euler(new Vector3(0,90,0))) as GameObject;
			GetComponent<ItemSpawner>().itemsAwake.Add(a);
		}
	}
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space))
			RandomDrop ();
	}
}
