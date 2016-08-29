using UnityEngine;
using System.Collections;

public class CollideWithBullets : MonoBehaviour 
{

	[SerializeField]
	private HealthAndDestroy healthScript;

	void OnTriggerEnter2D(Collider2D other)
	{
		healthScript.Health = healthScript.Health - 1;
		Destroy (other.gameObject);
	}
}
