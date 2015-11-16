using UnityEngine;
using System.Collections;

public class Assembly : MonoBehaviour 
{
	
public GameObject duck;

public void SpawnDuck()
{
	Debug.Log ("Spawn Duck");
	Instantiate(duck, transform.position, Quaternion.identity);
}
}