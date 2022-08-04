using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission2 : MonoBehaviour
{
    public float shouldThrow;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Gamemanager.instance.LoseUI.SetActive(true);
        }
    }
    private void Update()
    {
        if (shouldThrow <= Score.instance.scor && Gamemanager.instance.BallHp >= 0)
        {
            Gamemanager.instance.WinUiScreen();
        }
    }
}
