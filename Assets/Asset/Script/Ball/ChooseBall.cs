using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChooseBall : MonoBehaviour
{
    private string TopIsmi;

    public void ChooseBalls()
    {
        TopIsmi =EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(TopIsmi);
        PlayerPrefs.SetInt("color",int.Parse(TopIsmi));
    }
}
