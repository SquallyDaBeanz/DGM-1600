using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	Animator anim;

	void Start ()
	{
		//use getcomponent to get animator
		GameManager.OnDuckDeath += PlayDuck;
		GameManager.OnDuckFlyAway += PlayLaugh;
	}
	//Update is called once per frame
	//void Update ()
	//{
	//}
	public void SpawnDuck()
	{
		GameManager.OnSpawnDucks ();
	}
	public void PlayLaugh()
	{
		anim.Play("DogLaugh");
	}
	public void PlayDuck()
	{
		anim.Play("DogDuck");
	}
}
