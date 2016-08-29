using UnityEngine;
using System;

public class SwitchColour : MonoBehaviour {
	[SerializeField]
	private bool isRed = true;

	[SerializeField]
	private Sprite[] shipSprites;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	void Update()
	{
		if (Input.GetMouseButtonUp (0)) 
		{
			isRed = !isRed;
			print ("mouse up");
			spriteRenderer.sprite = shipSprites [Convert.ToInt32(isRed)];
		}
	}

	public bool IsRed
	{
		get{return isRed;}
		set { isRed = value; }
	}
}
