using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChooser : MonoBehaviour
{
    public Sprite[] colors;
    private SpriteRenderer spriteRenderer;
    void Awake()
    {
        spriteRenderer=gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = colors[PlayerPrefs.GetInt("color")];
    }
}
