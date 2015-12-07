﻿using UnityEngine;
using System.Collections;

public class DuckSpawner: MonoBehaviour 
{
	
public GameObject duck;

void Start ()
	{
		GameManager.OnSpawnDucks += SpawnDuck;
	}


public void SpawnDuck()
{
	Debug.Log ("Spawn Duck");
	Instantiate(duck, transform.position, Quaternion.identity);
}
}