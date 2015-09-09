using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour 
{   
	int MyInt = 5;
	void Start(){
		Debug.Log (MyInt);
		MyInt = MultiplyByTwo (MyInt);
		Debug.Log (MyInt);

	}

	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}