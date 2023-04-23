using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 50F;

    public void TakeDamage(float damage)
    {
        if (health <= damage)
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
        Destroy(gameObject);
    }
}
