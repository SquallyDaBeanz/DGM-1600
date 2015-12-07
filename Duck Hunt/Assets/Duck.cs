using UnityEngine;
using System.Collections;

public class Duck : MonoBehaviour 
{
	Animator anim;

	bool IsInvincible;

	void Start ()
	{
		//use getcomponent to get the animator and assign to anim
		GameManager.OnDuckMiss += MakeInvincible;
		GameManager.OnDuckShot += MakeInvincible;
	}



	void OnTriggerEnter(Collider hit)
	{
		if(hit.tag == "KillZone")
		{
			Destroy (this.gameObject);
		}

		if (hit.tag == "FlyZone") {
			Destroy (this.gameObject);
			GameManager.OnDuckFlyAway ();
		}
		
	}

	public void KillDuck()
	{
		if(IsInvincible == false)
		{
			Animator.Play("DuckDead");
			GameManager.OnDuckShot();


	public void MakeInvincible()
	{
		isInvincible = true;
	}

}