using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsUI : MonoBehaviour
{
    public Transform pantsParent;
    PantsInventory inventory;
    PantsSlot[] pantsSlots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = PantsInventory.instance;
        pantsSlots = pantsParent.GetComponentsInChildren<PantsSlot>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addToPantsInventory(Item item)
    {
        Debug.Log("J'ajoute un chapo");
        inventory.items.Add(item);
    }

    public void updateUI(Item item)
    {
        Debug.Log("update");
        for (int i = 0; i < pantsSlots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                Debug.Log("Je regarde un slot");
                pantsSlots[i].addItem(inventory.items[i]);
            }
            else
            {
                pantsSlots[i].clearSlot();
            }
        }
    }
}
