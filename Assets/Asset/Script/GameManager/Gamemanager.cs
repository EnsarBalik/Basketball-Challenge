using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    #region Public 
    public static Gamemanager instance;
    public Vector2 startPos, random;
    [SerializeField] GameObject MyBall;
    public Rigidbody2D MyBallrb;
    public Slider PowerBar;
    public TextMeshProUGUI BallHpTxt;
    public float BallHp;
    public GameObject LoseUI;
    public GameObject WinUI;
    public GameObject Greeen;
    public int CleanSayac;
    //------------------Score && Coin------------------------
    public int Coin = 0;
    public TextMeshProUGUI cointxt;
    public int Score;
    public TextMeshProUGUI scoretxt;
    #endregion

    private bool Win = false;
    private float power;
    float gucgecici;

    private void Start()
    {
        instance = this;
        Coin = PlayerPrefs.GetInt("Coins", Coin);
        Score = PlayerPrefs.GetInt("Scores", Score);
    }
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            power += 2;
            gucgecici = power;
            PowerBar.value = gucgecici;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            gucgecici = 0;
            power = 0;
            PowerBar.value = gucgecici;
        }
        PlayerPrefs.SetInt("Scores", Score);
        PlayerPrefs.SetInt("Coins", Coin);
    }
    public void SpawnBall()
    {
        Instantiate(MyBall, new Vector3(Random.Range(7.5f, -2.5f), Random.Range(0.5f, -2.5f)), Quaternion.identity);
        BallHp--;
        BallHpTxt.text = "x" + BallHp;
        return;
    }

    public void RestartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator deadwait()
    {
        yield return new WaitForSeconds(1);
        if (BallHp <= 0)
        {
            if (BallHp > 0)
            {
                yield break;
            }
            LoseUI.SetActive(true);
            if (Win == true)
            {
                LoseUI.SetActive(false);
            }
        }
    }

    public void GreenM()
    {
        if (Ball.instance.Clean == true)
        {
            Greeen.SetActive(true);
            StartCoroutine(GreenFalse());
        }
    }

    public void LoseUIScreen()
    {
        StartCoroutine(deadwait());
    }
    public void WinUiScreen()
    {
        WinUI.SetActive(true);
        Win = true;
        cointxt.text = "" + Coin;
        scoretxt.text =Score + " Score";
    }

    IEnumerator GreenFalse()
    {
        yield return new WaitForSeconds(2f);
        Greeen.SetActive(false);
        yield break;
    }
}
