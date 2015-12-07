using UnityEngine;
using System.Collections;

public class DirectionChanger : MonoBehaviour 
{
	public enum Changer{Horizontal, Vertical}
	public Changer changer;

	void onCollisionEnter(Collision hit)

	void Start()
	{
		GameManager.OnDuckShot += TurnOff;
		GameManager.OnDuckMiss += Turnoff;
		GameManager.OnSpawnDucks += TurnOn;

	{
		if (hit.transform.tag == "Duck") 
		{
			DuckMovement movement = hit.gameObject.GetComponent<DuckMovement> ();

			if (changer == Changer.Horizontal) 
			{

				movement.DirectionChanger (new Vector3(-1, 0, 0));
			} 

			else if(changer == Changer.Vertical)
			{
				movement.DirectionChanger (new Vector3(1, -1, 0));
			}
		}
	}

	public void TurnOff()
	{
		GameObject.SetActive (false);
	}
	public void TurnOn()
	{
		GameObject.SetActive (true);
	}

}
	