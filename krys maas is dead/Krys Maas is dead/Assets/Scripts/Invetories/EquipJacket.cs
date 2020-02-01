using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipJacket : MonoBehaviour
{
    public JacketsSlot jacketToEquip;
    public JacketsSlot equipedJacket;

    public void onClick()
    {
        swapJackets();
    }

    void swapJackets()
    {
        if (jacketToEquip.item == null)
        {
            Debug.Log("Choisis une case où ya un chat-pot stp :(");
            return;
        }

        Item tmpHat = equipedJacket.item;
        equipedJacket.clearSlot();
        equipedJacket.addItem(jacketToEquip.item);
        jacketToEquip.clearSlot();
        jacketToEquip.addItem(tmpHat);
    }
}
