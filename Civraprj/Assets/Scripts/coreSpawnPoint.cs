using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coreSpawnPoint : MonoBehaviour
{
    public GameObject core;

    int pressed = 0;

    public void pressedbutton()
    {
        spawnTheHELPPLEASE(); // yes i did actualy name it that im not gonna change it

        pressed+=1;

    }

    public void spawnTheHELPPLEASE()
    {
        if (pressed == 0)
        {
            Instantiate(core, transform.position, transform.rotation);
        }
    }



}
