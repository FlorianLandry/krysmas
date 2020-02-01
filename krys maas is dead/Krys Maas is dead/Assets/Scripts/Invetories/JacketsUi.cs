using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JacketsUi : MonoBehaviour
{
    public Transform jacketsParent;
    JacketInventory inventory;
    JacketsSlot[] jacketSlots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = JacketInventory.instance;
        jacketSlots = jacketsParent.GetComponentsInChildren<JacketsSlot>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addToJacketInventory(Item item)
    {
        Debug.Log("J'ajoute un chapo");
        inventory.items.Add(item);
    }

    public void updateUI(Item item)
    {
        Debug.Log("update");
        for (int i = 0; i < jacketSlots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                Debug.Log("Je regarde un slot");
                jacketSlots[i].addItem(inventory.items[i]);
            }
            else
            {
                jacketSlots[i].clearSlot();
            }
        }
    }
}
