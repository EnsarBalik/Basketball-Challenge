using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    #region Public
    public float power;
    public Rigidbody2D rb;
    public Slider PowerBar;
    public float life = 2.0f;
    public GameObject shadow;
    public bool hit_ground = false;
    public Vector2 startPos, random;
    public Animator BallAnim;
    public static Ball instance;
    public AudioSource FileSesi;
    public AudioSource GroundSesi;
    public AudioSource GroundSesi2;
    public AudioSource rimHit;
    #endregion
    float gucgecici;
    GameObject DownPlus, Down;
    public bool Clean = true;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("kacinciLevel"))
        {
            PlayerPrefs.SetInt("LoadSaved", 50);
            PlayerPrefs.SetInt("kacinciLevel", SceneManager.GetActiveScene().buildIndex);
        }
        shadow = (GameObject)Instantiate(shadow);
        instance = this;
        startPos = transform.position;
        Down = GameObject.Find("Ground");
        FileSesi = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetButton("Fire1") && transform.position.x == startPos.x)
        {
            power += 30;
            gucgecici = power;
            PowerBar.value = gucgecici;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            gucgecici = 0;
            PowerBar.value = gucgecici;
            Shoot();
        }

        if (hit_ground)
        {
            if (life <= 0)
            {
                Gamemanager.instance.SpawnBall();
                hit_ground = false;
                Destroy(gameObject);
                Destroy(shadow);
                Gamemanager.instance.LoseUIScreen();
            }
            else if (life > 0)
            {
                life -= Time.deltaTime;
                Color startColor = GetComponent<Renderer>().material.GetColor("_Color");
                GetComponent<Renderer>().material.SetColor("_Color", new Color(startColor.r, startColor.g, startColor.b, life));
                shadow.GetComponent<Renderer>().material.SetColor("_Color", new Color(startColor.r, startColor.g, startColor.b, life));
            }
        }
        shadow.transform.position = new Vector3(gameObject.transform.position.x, shadow.transform.position.y, gameObject.transform.position.z);
    }
    public void Shoot()
    {
        if (Gamemanager.instance.BallHp > 0)
        {
            //BallAnim.SetBool("Rotate", true);
            rb.constraints = RigidbodyConstraints2D.None;
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.AddForce(Vector2.left * power);
            rb.AddForce(Vector2.up * power / 1.1f);
            power = 0;
        }
        else if (Gamemanager.instance.BallHp <= 0)
        {
            //Do not write anything here.
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rim")
        {
            Clean = false;
            rimHit.Play();
        }
        if (collision.gameObject.tag == "Ground")
        {
            //BallAnim.SetBool("Rotate", false);
            hit_ground = true;
            GroundSesi.Play();
        }
        if (collision.gameObject.tag == "KarePota")
        {
            CameraShake.instance.StarterShake(.03f, .03f);
            GroundSesi2.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Sayac")
        {
            if (Clean == true)
            {
                Gamemanager.instance.GreenM();
                Gamemanager.instance.CleanSayac++;
                Gamemanager.instance.Score += 200;
                AllBalsMission.instance.CleanmSayac++;
                if (Gamemanager.instance.CleanSayac > 3)
                {
                    Gamemanager.instance.Coin += 30;
                    
                }
            }
            else if (Clean == false)
            {
                
            }
            CameraShake.instance.StarterShake(.05f, .05f);
            basket();
            Gamemanager.instance.Score += 100;
            AllBalsMission.instance.BasketSayac++;
        }
    }

    void basket()
    {
        FileSesi.Play();
    }
}
