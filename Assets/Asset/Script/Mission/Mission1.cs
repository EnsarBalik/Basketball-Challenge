using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission1 : MonoBehaviour
{
    public float shouldThrow;
    public GameObject Intro;

    public void Update()
    {
        if (shouldThrow <= Score.instance.scor && Gamemanager.instance.BallHp >= 0)
        {
            Gamemanager.instance.WinUiScreen();
        }
        StartCoroutine(DeleteMission());
    }
    IEnumerator DeleteMission()
    {
        yield return new WaitForSeconds(2.2f);
        Destroy(Intro);
        yield break;
    }
}
