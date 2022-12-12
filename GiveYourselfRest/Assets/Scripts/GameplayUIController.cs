using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{

    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ResetButton()
    {
        SceneManager.LoadScene("Gameplay");
    }

}
