using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public int scor;
    public TextMeshProUGUI ScorTxt;
    public Animator anim;
    
    public void Start()
    {
        instance = this;   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            scor++;
            ScorTxt.text = "" + scor;
            anim.SetTrigger("Basket");
        }
    }
}
