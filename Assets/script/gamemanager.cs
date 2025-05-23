using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
  public static Gamemanager instance;
  private void Awake()
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
    public InventoryPanel inventoryPanel;
    public void OpenInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(true);
        inventoryPanel.Onopen();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //Time.timeScale = 0f;
    }
    public void CloseInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //Time.timeScale = 1f;
    }
    public float timeCounter = 30f;
    public Itemdata targetItem;
    public int targetAmount = 5;
    public TMP_Text timeCounterTex;
    public Image targetItemicon;
    public TMP_Text targetCurrentAmountText;

    public void Start()
    {
        targetItemicon.sprite = targetItem.itemicon;
    }
    private void Update()
    {
        targetItemicon.sprite = targetItem.itemicon;
        if (timeCounter > 0)
        {
            timeCounter -= Time.deltaTime;
            timeCounterTex.text = timeCounter.ToString("0");
            targetCurrentAmountText.text = (targetAmount - InventoryManager.instance.GetItemAmount(targetItem)).ToString();
            if (InventoryManager.instance.GetItemAmount(targetItem) >= targetAmount) // playerwin//
            {
                Debug.Log("Player Win");
            }
        }   
        else// player lose//
        {
            SceneManager.LoadScene("Mainmenu");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
