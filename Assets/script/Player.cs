using UnityEngine;

public class Player : MonoBehaviour
{
    private LayerMask mask;
    void Start()
    {
        mask = LayerMask.GetMask("Interactable");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position,Camera.main.transform.forward * 5f, Color.green);
        if (Input.GetMouseButtonDown(0))
        {
           
            if (Physics.Raycast(Camera.main.transform.position,
                Camera.main.transform.forward,
                out RaycastHit hit,
                15f, mask))
                {
                    Debug.Log("hit something");
                    IInteractable comp = hit.collider.gameObject.GetComponent<IInteractable>();
                    comp.Interact();
                }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Gamemanager.instance.OpenInventoryPanel();
        }
        if (Input.GetKeyDown(KeyCode.R))
        { 
            Gamemanager.instance.CloseInventoryPanel(); 
        }
             
    }
    }
    

