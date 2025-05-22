using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public List<itemdata> inventoryList = new List<itemdata>();

    public void AddItem(itemdata item)
    {
        inventoryList.Add(item);
    }
    public int GetItemAmount(itemdata data)
    {
        int amount = 0;
        foreach (itemdata item in inventoryList)
        {
            if (item == data)
            {
                amount++;
            }
        }
        return amount;

    }
}
