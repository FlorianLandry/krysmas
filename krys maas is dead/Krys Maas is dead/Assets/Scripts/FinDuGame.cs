using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinDuGame : Interactable
{
    public override void interact(){
        theEnd();
    }

    private void theEnd()
    {
        GameObject.Find("BonnetNoel").GetComponent<Renderer>().enabled = true;
    }
}
