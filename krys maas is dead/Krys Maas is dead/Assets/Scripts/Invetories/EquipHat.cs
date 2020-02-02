using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipHat : MonoBehaviour
{
    public HatsSlot hatToEquip;
    public HatsSlot equipedHat;

    public void onClick()
    {
        swapHats();
    }

    void swapHats()
    {
        if(hatToEquip.item == null)
        {
            Debug.Log("Choisis une case où ya un chat-pot stp :(");
            return;
        }

        Item tmpHat = equipedHat.item;
        GameObject.Find(equipedHat.item.name).GetComponent<Renderer>().enabled = false;
        equipedHat.clearSlot();
        equipedHat.addItem(hatToEquip.item);
        if (equipedHat.item.name != "CacheOreilles")
        {
            GameObject.Find("QueueDeCheval").GetComponent<Renderer>().enabled = false;
        }
        else
        {
            GameObject.Find("QueueDeCheval").GetComponent<Renderer>().enabled = true;
        }
        GameObject.Find(equipedHat.item.name).GetComponent<Renderer>().enabled = true;
        hatToEquip.clearSlot();
        hatToEquip.addItem(tmpHat);
    }
}
