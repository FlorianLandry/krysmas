using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipPants : MonoBehaviour
{
    public PantsSlot pantsToEquip;
    public PantsSlot equipedPants;

    public void onClick()
    {
        swapPants();
    }

    void swapPants()
    {
        if (pantsToEquip.item == null)
        {
            Debug.Log("Choisis une case où ya un chat-pot stp :(");
            return;
        }

        Item tmpHat = equipedPants.item;
        equipedPants.clearSlot();
        equipedPants.addItem(pantsToEquip.item);
        pantsToEquip.clearSlot();
        pantsToEquip.addItem(tmpHat);
    }
}
