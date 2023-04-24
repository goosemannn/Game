using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	public float health = 75F;

	public void TakeDamage(float damage)
	{
		if (damage >= health)
		{
			die();
		}
		else
		{
			health -= damage;
		}
	}

	private void die()
	{
		SceneManager.LoadScene("dead");
	}
}
