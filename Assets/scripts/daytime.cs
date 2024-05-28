using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class daytime : MonoBehaviour
{
    [SerializeField] private float actualTime;
    [SerializeField] private float nightTime;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] GameObject gameVictoryMenu;


    void Update()
    {

        actualTime += Time.deltaTime;
        timeText.SetText(Mathf.Round(actualTime).ToString());

        if (actualTime >= nightTime)
        {
            Debug.Log("victory");
            gameVictoryMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
