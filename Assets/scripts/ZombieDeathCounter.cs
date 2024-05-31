using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZombieDeathCounter : MonoBehaviour
{
    [SerializeField] int deathCounter;
    [SerializeField] TextMeshProUGUI victoryDeath;
    [SerializeField] TextMeshProUGUI gameOverDeath;
    [SerializeField] TextMeshProUGUI bestDeathCountGameOver;
    [SerializeField] TextMeshProUGUI bestDeathCountVictory;
    

    public void OnZombieDeath()
    {
        deathCounter++;
        victoryDeath.SetText("������: " + deathCounter);
        gameOverDeath.SetText("������: " + deathCounter);

        if (deathCounter > PlayerPrefs.GetInt("recordKills"))
        {
            Debug.Log("newrecord" + deathCounter);
            PlayerPrefs.SetInt("recordKills", deathCounter);
            bestDeathCountGameOver.SetText("������ �� ������:  " + deathCounter);
            bestDeathCountVictory.SetText("������ �� ������:  " + deathCounter);
        }
    }
}
