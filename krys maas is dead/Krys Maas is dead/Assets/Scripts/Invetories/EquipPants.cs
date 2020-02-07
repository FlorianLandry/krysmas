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
        GameObject.Find(equipedPants.item.name).GetComponent<Renderer>().enabled = false;
        equipedPants.clearSlot();
        equipedPants.addItem(pantsToEquip.item);
        if (equipedPants.item.name != "PantalonDeRando")
        {
            GameObject.Find("Jambes").GetComponent<Renderer>().enabled = true;
            GameObject.Find("Pieds").GetComponent<Renderer>().enabled = true;
        }
        else
        {
            GameObject.Find("Jambes").GetComponent<Renderer>().enabled = false;
            GameObject.Find("Pieds").GetComponent<Renderer>().enabled = false;
        }
        GameObject.Find(equipedPants.item.name).GetComponent<Renderer>().enabled = true;
        pantsToEquip.clearSlot();
        pantsToEquip.addItem(tmpHat);
    }
}
