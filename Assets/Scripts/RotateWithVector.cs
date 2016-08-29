using UnityEngine;
using System.Collections;

public class RotateWithVector : MonoBehaviour {

	[SerializeField]
	private Vector3 rotationVector;

	[SerializeField]
	private float speed = 10;

	void Update () 
	{
		transform.Rotate (rotationVector * speed * Time.deltaTime);
	}
}
