using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControlller : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject TopPaneli;
    public void PlayBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void FreeMode()
    {
        SceneManager.LoadScene("FreeMode");
    }
    public void ChooseBall()
    {
        TopPaneli.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void Back()
    {
        mainMenu.SetActive(true);
        TopPaneli.SetActive(false);
    }
}
