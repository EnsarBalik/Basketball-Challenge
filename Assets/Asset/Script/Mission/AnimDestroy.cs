using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDestroy : MonoBehaviour
{
    public GameObject Intro;
    private void Start()
    {
        StartCoroutine(DeleteMission());
    }

    IEnumerator DeleteMission()
    {
        yield return new WaitForSeconds(2.2f);
        Destroy(Intro);
        yield break;
    }
}
