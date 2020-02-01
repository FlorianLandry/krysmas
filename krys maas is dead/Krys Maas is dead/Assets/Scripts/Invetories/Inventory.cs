using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public delegate void onHatChanged(Item item);
    public onHatChanged onHatChangedCallback;
    public delegate void onJacketChanged(Item item);
    public onJacketChanged onJacketChangedCallback;
    public delegate void onPantsChanged(Item item);
    public onPantsChanged onPantsChangedCallback;
    public static Inventory instance;
    #region Singleton


    private void Awake()
    {
        if(instance != null)
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

    
    public List<Item> items = new List<Item>();
    public int space = 4;

    

    public bool add(Item item)
    {
        if(items.Count >= space)
        {
            Debug.Log("Not enough space");
            return false;
        }
        if(item.type == "hat")
        {
            if (onHatChangedCallback != null)
            {
                onHatChangedCallback.Invoke(item);
            }
        } else if(item.type == "pants")
        {
            if (onHatChangedCallback != null)
            {
                onPantsChangedCallback.Invoke(item);
            }
        } else if(item.type == "jacket")
        {
            if (onJacketChangedCallback != null)
            {
                onJacketChangedCallback.Invoke(item);
            }
        }
        else
        {
            Debug.Log("C'est pas un item d'armure à équiper :/");
        } 
        
        return true;
    }

    public void remove(Item item)
    {
        items.Remove(item);
        if (item.type == "pants")
        {

        }
        else if (item.type == "hat")
        {
            if (onHatChangedCallback != null)
            {
                onHatChangedCallback.Invoke(item);
            }
        }
        else
        {

        }
        
    }
}
