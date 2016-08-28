using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootToFire : MonoBehaviour 
{
	[SerializeField]
	private GameObject shootLaser;

	[SerializeField]
	private float bulletYPostionModifier;

	[SerializeField]
	private float timer;

	[SerializeField]
	private SnapToMouse snapToMouse;

	void Start () 
	{
		StartCoroutine (WaitForRefire ());
	}


	IEnumerator WaitForRefire()
	{
		yield return new WaitForSeconds (timer);
		if ((this.transform.position == snapToMouse.PlacementVector)) 
		{
			if(Input.GetMouseButton(0))
			{
			Instantiate (shootLaser,new Vector3 (transform.position.x,transform.position.y+bulletYPostionModifier), Quaternion.identity);
			}
		}
		StartCoroutine (WaitForRefire ());
	}
}
