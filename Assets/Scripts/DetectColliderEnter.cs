using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColliderEnter : MonoBehaviour
{
	public bool inSwordCollisionRange = false;


	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "SwordCollider")
		{
			inSwordCollisionRange = true;
		}
	}

	void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "SwordCollider")
		{
			inSwordCollisionRange = false;
		}
	}
}
