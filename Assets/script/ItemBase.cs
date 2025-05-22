using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public itemdata data;
    public void Interact()
    {
        Debug.Log("interact item : "+data.name);
        InventoryManager.instance.AddItem(data);    
        Destroy(gameObject);
    }
}

