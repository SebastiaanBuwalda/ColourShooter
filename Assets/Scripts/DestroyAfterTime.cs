using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour 
{
	[SerializeField]
	private float destroyTime = 10;

	void Start()
	{
		StartCoroutine (DestroyTimer ());
	}

	IEnumerator DestroyTimer()
	{
		yield return new WaitForSeconds (destroyTime);
		Destroy (this.gameObject);
	}
}
