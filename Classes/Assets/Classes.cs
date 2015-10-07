using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour 
{

	public class Health
	{
		public int maxHP;
		public int currentHP;
		public int minimumHP;

		public Health (int maxHP, int currentHP)
	
		{


	
			maxHP = 100;
			currentHP = maxHP;
			currentHP = 58;
			minimumHP = 20;
			
		}
		public Health characterHealth = new Health (150);
		public Health followerHealth = new Health (12);
	}
	void Start () 
	{
		Debug.Log(characterHealth.currentHP);

	}
}