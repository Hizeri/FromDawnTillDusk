using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] int durability;

    [SerializeField] GameObject gameOverMenu;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GetDemage(int demage)
    {
        durability -= demage;
        if (durability <= 0)
        {
            Destroy(gameObject);
            Debug.Log("loser");
            gameOverMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
