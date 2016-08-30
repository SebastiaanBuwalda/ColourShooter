using UnityEngine;
using System.Collections;

public class CollideWithBullets : MonoBehaviour 
{

	[SerializeField]
	private HealthAndDestroy healthScript;

	[SerializeField]
	private string hurtfullString;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == hurtfullString) {
			healthScript.Health = healthScript.Health - 1;
			Destroy (other.gameObject);
		}
	}


	public string HurtfullString
	{
		get{return hurtfullString;}
		set { hurtfullString = value; }
	}
}
