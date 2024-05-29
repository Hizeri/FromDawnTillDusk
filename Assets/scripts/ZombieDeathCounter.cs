using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZombieDeathCounter : MonoBehaviour
{
    [SerializeField] int deathCounter;
    [SerializeField] TextMeshProUGUI victoryDeath;
    [SerializeField] TextMeshProUGUI gameOverDeath;

    public void OnZombieDeath()
    {
        deathCounter++;
        victoryDeath.SetText("‘–¿√Œ¬: " + deathCounter);
        gameOverDeath.SetText("‘–¿√Œ¬: " + deathCounter);
    }
}
