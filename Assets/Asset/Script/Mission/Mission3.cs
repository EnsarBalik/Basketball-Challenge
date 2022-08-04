using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission3 : MonoBehaviour
{
    public int HaveClean;

    public void Update()
    {
        if (HaveClean == Gamemanager.instance.CleanSayac)
        {
            Gamemanager.instance.WinUiScreen();
        }
    }

}
