using UnityEngine;
using System.Collections;

public class Duck : MonoBehaviour 
{

	void OnTriggerEnter(Collider hit)
	{
		if(hit.tag == "KillZone")
		{
			Destroy (this.gameObject);
		}
	}
}