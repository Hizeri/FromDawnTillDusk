using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI recordText;
    private void Start()
    {
        recordText.SetText("–≈ Œ–ƒ œŒ ‘–¿√¿Ã:  " + PlayerPrefs.GetInt("recordKills"));
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
