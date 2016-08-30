using UnityEngine;
using System.Collections;

public class FollowGameObject : MonoBehaviour {

	[SerializeField]
	private GameObject objectToFollow;

	[SerializeField]
	private float distanceDelta = .03F;

	[SerializeField]
	private bool freezeYPosition;

	void Update () 
	{
		if(!freezeYPosition)
		transform.position = Vector2.MoveTowards (transform.position, objectToFollow.transform.position, distanceDelta);
		else
		transform.position = Vector2.MoveTowards (transform.position, new Vector2(objectToFollow.transform.position.x, this.gameObject.transform.position.y), distanceDelta);
			
	}
}
