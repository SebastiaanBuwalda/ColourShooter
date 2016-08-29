using UnityEngine;
using System.Collections;

public class MoveWithVecor : MonoBehaviour {

	[SerializeField]
	private Vector3 moveVector;

	void Update () 
	{
		transform.Translate (moveVector * Time.deltaTime, Space.World);
	}
}
