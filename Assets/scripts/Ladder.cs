using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    [SerializeField] int durability;

    public void GetDemage(int demage)
    {
        durability -= demage;
        if (durability <= 0)
        {
            Destroy(gameObject);
            Debug.Log("ladder broken");
            
        }
    }

}

