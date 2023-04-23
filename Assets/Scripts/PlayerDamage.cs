using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public GameObject playerCollider;
    public Transform enemies;
    public float damage = 25F;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (Transform child in enemies)
            {
                if (child.GetComponent<DetectColliderEnter>().inSwordCollisionRange == true)
                {
                    child.GetComponent<Health>().TakeDamage(damage);
                }
            }
        }
    }


}
