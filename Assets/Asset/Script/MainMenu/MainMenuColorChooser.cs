using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuColorChooser : MonoBehaviour
{
    public Sprite[] colors;
    private SpriteRenderer spriteRenderer;
    public void Update()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = colors[PlayerPrefs.GetInt("color")];
    }
}
