using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{
    public void OnPressStartButton()
    { 
        SceneManager.LoadScene("Gameplay");
    }
}
