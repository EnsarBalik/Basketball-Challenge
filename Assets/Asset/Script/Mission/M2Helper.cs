using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M2Helper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Gamemanager.instance.SpawnBall();
            Destroy(collision.gameObject);
        }
    }
}
