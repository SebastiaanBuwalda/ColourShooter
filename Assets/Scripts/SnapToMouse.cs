using UnityEngine;
using System.Collections;
public class SnapToMouse : MonoBehaviour
{
	[SerializeField]
	private Camera mainCamera;

	private Vector3 placementVector;

	[SerializeField]
	private float zPosition;

	void LateUpdate () 
	{
		if (Input.GetMouseButton (0)) 
		{
			placementVector = new Vector3 ((mainCamera.ScreenToWorldPoint (Input.mousePosition).x), (mainCamera.ScreenToWorldPoint (Input.mousePosition).y), zPosition);
			this.transform.position = placementVector;
		}
	}


	public Vector3 PlacementVector
	{
		get {return placementVector;}
	}
}
