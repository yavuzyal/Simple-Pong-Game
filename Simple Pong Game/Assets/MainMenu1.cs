using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    
    public void StartGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(1);
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
}