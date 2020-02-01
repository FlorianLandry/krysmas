using UnityEngine;
using UnityEngine.UI;

public class JacketsSlot : MonoBehaviour
{
    public Image icon;
    public Item item;

    public void addItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        Debug.Log("SALUTUUUUUUUUUUUUUUU");
    }

    public void clearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
