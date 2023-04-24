using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColliderEnter : MonoBehaviour
{
	public bool inPlayerFollowArea = false;

	public bool inSwordLeftCollisionRange = false;
	public bool inSwordRightCollisionRange = false;


	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "SwordCollider")
		{
			if (collision.gameObject.layer == 6)
			{
				inSwordLeftCollisionRange = true;
			}
			else if (collision.gameObject.layer == 7)
			{
				inSwordRightCollisionRange = true;
			}
		}
		else if (collision.gameObject.tag == "PlayerFollowArea")
		{
			inPlayerFollowArea = true;
		}

	}

	void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "SwordCollider")
		{
			if (collision.gameObject.layer == 6)
			{
				inSwordLeftCollisionRange = false;
			}
			else if (collision.gameObject.layer == 7)
			{
				inSwordRightCollisionRange = false;
			}
		}
		else if (collision.gameObject.tag == "PlayerFollowArea")
		{
			inPlayerFollowArea = false;
		}
	}
}
