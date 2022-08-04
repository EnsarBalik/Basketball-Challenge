using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBalsMission : MonoBehaviour
{
    //1- toplam 50 clean atarsa "YE�IL" topu a�
    //2- toplam 20 tane basket atarsa "MAVI" topu a�
    //3- toplam 40 tane bakset atarsa "KIRMIZI" topu a�
    //4- toplam 60 tane basket atarsa "BORDO" topu a�
    //5- toplam 70 clean atarsa "BEYAZ" topu a�
    //6- toplam 80 clean ve 80 basket atarsa "SIYAH" topu a�
    //7- toplam 100 clean ve 100 basket atarsa "Rainbow" topu a�
    //8- toplam 110 clean ve 120 basket atarsa "reflective" topu a�

    public int CleanmSayac;
    public int BasketSayac;
    public static AllBalsMission instance;

    private void Start()
    {
        instance = this;
        CleanmSayac = PlayerPrefs.GetInt("clean", CleanmSayac);
        BasketSayac = PlayerPrefs.GetInt("basket", BasketSayac);
    }
    private void Update()
    {
        PlayerPrefs.SetInt("clean", CleanmSayac);
        PlayerPrefs.SetInt("basket", BasketSayac);
    }
}
