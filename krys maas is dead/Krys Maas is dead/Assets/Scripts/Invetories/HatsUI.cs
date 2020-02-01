using UnityEngine;

public class HatsUI : MonoBehaviour
{
    public Transform hatsParent;
    HatInventory inventory;
    HatsSlot[] hatSlots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = HatInventory.instance;
        hatSlots = hatsParent.GetComponentsInChildren<HatsSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addToHatInventory(Item item)
    {
        Debug.Log("J'ajoute un chapo");
        inventory.items.Add(item);
    }

    public void updateUI(Item item)
    {
        Debug.Log("update");
        for (int i = 0; i < hatSlots.Length; i++)
        {
            if(i < inventory.items.Count)
            {
                Debug.Log("Je regarde un slot");
                hatSlots[i].addItem(inventory.items[i]);
            }
            else
            {
                hatSlots[i].clearSlot();
            }
        }
    }
}
