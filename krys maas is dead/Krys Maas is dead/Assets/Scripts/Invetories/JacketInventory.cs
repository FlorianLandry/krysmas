using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JacketInventory : Inventory
{
    public new static JacketInventory instance;

    #region Singleton


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of inventory found !!!!!");
            return;
        }
        instance = this;
        GameObject canvas = GameObject.Find("Canvas");
        instance.onHatChangedCallback += canvas.GetComponent<HatsUI>().addToHatInventory;
        instance.onHatChangedCallback += canvas.GetComponent<HatsUI>().updateUI;
        instance.onJacketChangedCallback += canvas.GetComponent<JacketsUi>().addToJacketInventory;
        instance.onJacketChangedCallback += canvas.GetComponent<JacketsUi>().updateUI;
        instance.onPantsChangedCallback += canvas.GetComponent<PantsUI>().addToPantsInventory;
        instance.onPantsChangedCallback += canvas.GetComponent<PantsUI>().updateUI;
    }

    #endregion
}
