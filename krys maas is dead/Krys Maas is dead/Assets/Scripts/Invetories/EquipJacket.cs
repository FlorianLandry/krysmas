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
        GameObject.Find(equipedJacket.item.name).GetComponent<Renderer>().enabled = false;
        equipedJacket.clearSlot();
        equipedJacket.addItem(jacketToEquip.item);
        if (equipedJacket.item.name != "VesteHiver")
        {
            GameObject.Find("TShirt").GetComponent<Renderer>().enabled = true;
            GameObject.Find("Bras").GetComponent<Renderer>().enabled = false;
        }
        else
        {
            GameObject.Find("TShirt").GetComponent<Renderer>().enabled = false;
            GameObject.Find("Bras").GetComponent<Renderer>().enabled = false;
        }
        GameObject.Find(equipedJacket.item.name).GetComponent<Renderer>().enabled = true;
        jacketToEquip.clearSlot();
        jacketToEquip.addItem(tmpHat);
    }
}
