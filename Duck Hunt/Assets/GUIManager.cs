using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {

	public GameObject[] bullets;
	void Start () 
	{
	
		GameManager.OnSpawnDucks = ResetBullets;

	}


	public void DisableBullet(int index)
	{
		bullets [index].SetActive(false);
	}

	void ResetBullets()
	{
	foreach (GameObject bul in bullets) 
		{
			//in shooter script, make public game object variable and assign the cavas to. Use GetComponent to get the script from it. Use that variable to recall the disable bullets function.
			bul.SetActive (true);
		}
	}
}
