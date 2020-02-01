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
        equipedHat.clearSlot();
        equipedHat.addItem(hatToEquip.item);
        hatToEquip.clearSlot();
        hatToEquip.addItem(tmpHat);
    }
}
