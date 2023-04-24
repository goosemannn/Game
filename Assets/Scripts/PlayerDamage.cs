using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public GameObject playerCollider;
    public GameObject player;
    public Transform enemies;
    public float damage = 25F;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (Transform child in enemies)
            {
                if (child.GetComponent<DetectColliderEnter>().inSwordLeftCollisionRange == true && player.GetComponent<PlayerMovement>().left == true)
                {
                    child.GetComponent<Health>().TakeDamage(damage);
                }
                else if (child.GetComponent<DetectColliderEnter>().inSwordRightCollisionRange == true && player.GetComponent<PlayerMovement>().left == false)
                {
                    child.GetComponent<Health>().TakeDamage(damage);
                }
            }
        }
    }


}
