using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Coinn;
    public AudioSource CoinSound;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Gamemanager.instance.Coin++;
            float x = Random.Range(-5f, -1f);
            float y = Random.Range(-1.20f, 0f);
            CoinSound.Play();
            Coinn.transform.position = new Vector3(x, y, 0);
        }
    }
}
