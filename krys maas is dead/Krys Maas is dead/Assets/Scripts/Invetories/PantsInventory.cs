﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsInventory : Inventory
{
    public new static PantsInventory instance;

    #region Singleton


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of inventory found !!!!!");
            return;
        }
        instance = this;
        instance.onHatChangedCallback += canvas.GetComponent<HatsUI>().addToHatInventory;
        instance.onHatChangedCallback += canvas.GetComponent<HatsUI>().updateUI;
        instance.onJacketChangedCallback += canvas.GetComponent<JacketsUi>().addToJacketInventory;
        instance.onJacketChangedCallback += canvas.GetComponent<JacketsUi>().updateUI;
        instance.onPantsChangedCallback += canvas.GetComponent<PantsUI>().addToPantsInventory;
        instance.onPantsChangedCallback += canvas.GetComponent<PantsUI>().updateUI;
    }

    #endregion
}
