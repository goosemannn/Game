using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if (GetComponent<DetectColliderEnter>().inPlayerFollowArea == true)
        {
            if (transform.position.x > player.transform.position.x)
            {
                transform.Translate(-.007F, 0, 0);
            }
            if (transform.position.x < player.transform.position.x)
            {
                transform.Translate(.007F, 0, 0);
            }
            if (transform.position.y > player.transform.position.y)
            {
                transform.Translate(0, -.007F, 0);
            }
            if (transform.position.y < player.transform.position.y)
            {
                transform.Translate(0, .007F, 0);
            }
        }
    }
}
