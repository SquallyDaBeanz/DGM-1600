using UnityEngine;
using System.Collections;

public class Duck : MonoBehaviour 
{
	public void OnTiggerEnter(Collider hit)
	{
		print ("test");
		if(hit.tag == "KillZone")
		{
			Destroy(this.gameObject);
		}
	}

}
