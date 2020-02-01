using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : Interactable
{
    public Item item;

    public override void interact()
    {
        pickUp();
    }

    void pickUp()
    {
        Debug.Log("Picking up" + item.itemName);
        bool isPickedUp = Inventory.instance.add(item);
        pc.focus = null;
        if (isPickedUp)
        {
            Destroy(gameObject);
        }
        
        
    }
}
