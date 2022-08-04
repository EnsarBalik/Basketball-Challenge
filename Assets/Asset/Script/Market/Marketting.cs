using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marketting : MonoBehaviour
{
    public GameObject Ballblue;
    public GameObject ballgreen;
    public GameObject ballred;
    public GameObject ballDred;
    public GameObject ballwhite;
    public GameObject ballblack;
    public GameObject ballrainbow;
    public GameObject ballreflective;

    void Start()
    {
        //Money = PlayerPrefs.GetFloat("Money");
    }

    public void Update()
    {
        if (AllBalsMission.instance.CleanmSayac >= 50)
            ballgreen.GetComponent<Button>().interactable = true;
        if(AllBalsMission.instance.CleanmSayac >= 70)
            ballwhite.GetComponent<Button>().interactable = true;
        if(AllBalsMission.instance.BasketSayac >= 20)
            Ballblue.GetComponent<Button>().interactable = true;
        if(AllBalsMission.instance.BasketSayac >= 40)
            ballred.GetComponent<Button>().interactable = true;
        if(AllBalsMission.instance.BasketSayac >= 60)
            ballDred.GetComponent<Button>().interactable = true;
        if(AllBalsMission.instance.BasketSayac >= 80 && AllBalsMission.instance.CleanmSayac >= 80)
            ballblack.GetComponent<Button>().interactable = true;
        if(AllBalsMission.instance.BasketSayac >= 100 && AllBalsMission.instance.CleanmSayac >= 100)
            ballrainbow.GetComponent<Button>().interactable = true;
        if (AllBalsMission.instance.BasketSayac >= 110 && AllBalsMission.instance.CleanmSayac >= 110)
            ballreflective.GetComponent<Button>().interactable = true;
    }
}
