using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public float damage = 10F;
	public bool AbleToAttackPlayer = true;

	private void Attack(Collision2D collision)
	{
		if (AbleToAttackPlayer == true)
		{
			if (collision.gameObject.tag == "Player")
			{
				collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
				AbleToAttackPlayer = false;
				StartCoroutine(reenableHittingPlayer(collision));

			}

		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Attack(collision);
	}

	IEnumerator reenableHittingPlayer(Collision2D collision)
	{
		yield return new WaitForSeconds(2.5F);
		AbleToAttackPlayer = true;
		if (GetComponent<Collider2D>().IsTouching(collision.gameObject.GetComponent<Collider2D>()))
		{
			Attack(collision);
		}

	}
}
