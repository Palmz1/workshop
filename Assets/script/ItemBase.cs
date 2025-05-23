using UnityEngine;

public class ItemBase : MonoBehaviour, IInteractable
{
    public Itemdata data;
    public void Interact()
    {
        Debug.Log("interact item : "+data.name);
        InventoryManager.instance.AddItem(data);
        Destroy(gameObject);
    }
}

