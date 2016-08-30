using UnityEngine;
using System.Collections;

public class SpawnObjectsInIntervals : MonoBehaviour 
{
	[SerializeField]
	private float startUpTime = 5;

	[SerializeField]
	private float interval = 1;

	[SerializeField]
	private GameObject[] possibleObjects;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (StartUp ());
	}


	IEnumerator StartUp()
	{
		yield return new WaitForSeconds (startUpTime);
		StartCoroutine (SpawnObject ());
	}

	IEnumerator SpawnObject()
	{
		Instantiate (possibleObjects [Random.Range (0, possibleObjects.Length)],transform.position,Quaternion.identity);
		yield return new WaitForSeconds (interval);
		StartCoroutine (SpawnObject ());
	}
}
