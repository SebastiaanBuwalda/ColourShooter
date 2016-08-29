using UnityEngine;
using System;

public class SwitchColour : MonoBehaviour {
	[SerializeField]
	private bool isRed = true;

	[SerializeField]
	private Sprite[] shipSprites;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private CollideWithBullets collideWithBullets;

	void Update()
	{
		if (Input.GetMouseButtonUp (0)) 
		{
			isRed = !isRed;
			spriteRenderer.sprite = shipSprites [Convert.ToInt32(isRed)];
			if (collideWithBullets.HurtfullString == Tags.blueEnemyFire) {
				collideWithBullets.HurtfullString = Tags.redEnemyFire;
			}
			else if (collideWithBullets.HurtfullString == Tags.redEnemyFire) {
				collideWithBullets.HurtfullString = Tags.blueEnemyFire;
			}
		}
	}

	public bool IsRed
	{
		get{return isRed;}
		set { isRed = value; }
	}
}
