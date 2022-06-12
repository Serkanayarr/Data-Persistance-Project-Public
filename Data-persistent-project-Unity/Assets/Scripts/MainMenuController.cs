using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuController : MonoBehaviour
{
    public TMP_InputField inputName;
    public Button startButton;
    
    void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void SetPlayerName()
    {
        GameManager.instance.playerName = inputName.text;
    }

    public void Exit()
    {
        
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif

    }

    public void BestScores()
    {
        SceneManager.LoadScene("BestScores");
    }
}
