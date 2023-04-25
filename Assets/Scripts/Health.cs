using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 50F;
    public GameObject player;

    public void TakeDamage(float damage)
    {
        if (health <= damage)
        {
            player.GetComponent<KillCounter>().addToKillCounter();
            die();
        }
        else
        {
            health -= damage;
        }
    }

    private void die()
    {
        Destroy(gameObject);
    }
}
