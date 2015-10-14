using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour 
{
	public class Health
	{
	public int BaseHealth;
	


	public Health (int maxHP)
	{
		BaseHealth = maxHP;
		
		}

		public Health ()
		{
			BaseHealth = 100;
		}
	}
		public Health MyHealth = new Health (150);



	void Start()
{
	Debug.Log (MyHealth.BaseHealth);

}
}