﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinDuGame : Interactable
{
    public GameObject timeline;
    public GameObject froidendu;
    public Cinemachine.CinemachineBrain cinemachineBrain;

    public override void interact(){
        theEnd();
    }

    private void theEnd()
    {
        GameObject.Find("BonnetNoel").GetComponent<Renderer>().enabled = true;
        froidendu.SetActive(false);
        timeline.SetActive(true);
        cinemachineBrain.enabled = true;
    }
}
