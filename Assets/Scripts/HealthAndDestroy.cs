using UnityEngine;
using System.Collections;

public class HealthAndDestroy : MonoBehaviour 
{
	[SerializeField]
	private int health = 5;



	void Update ()
	{
		if(health<=0)
		{
			Destroy ();
		}
	}

	void Destroy()
	{
		Destroy (gameObject);
	}


	public int Health
	{
		get{return health;}
		set { health = value; }
	}

}
