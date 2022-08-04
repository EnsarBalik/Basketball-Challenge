using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelGo : MonoBehaviour
{
    public GameObject leveller1;
    void Start()
    {
        for (int i = 0; i < leveller1.transform.childCount; i++)
        {
            leveller1.transform.GetChild(i).gameObject.SetActive(true);
        }

        for (int i = 0; i < PlayerPrefs.GetInt("kacinciLevel"); i++)
        {
            leveller1.transform.GetChild(i).GetComponent<Button>().interactable = true;
        }
    }

    public void leveller(int gelenLevel)
    {
        SceneManager.LoadScene(gelenLevel);
    }
}
