using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour 
{

	RaycastHit hit;

	private int bulletAmt;
	public int maxBullets;

	void start()
	{

	}

	void update()
	
	{

		if(Input.GetMouseButtonDown(0))
		{
			bulletAmt--;

			if(bulletAmt <= 0)
			{
				GameManager.OnDuckMiss();
			}

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;

			if(Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
			{
				if(hit.transform.tag == "Duck")
				{
					//use getcomponent in hit to get the duck health script. (script that deletes the duck) Killzone? or just "Duck" script. Using that, call the killduck in duck health script. For the KillDuck function.
				}
			}
		}
	}
}