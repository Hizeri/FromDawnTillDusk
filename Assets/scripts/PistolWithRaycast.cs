using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class PistolWithRaycast : MonoBehaviour
{
    private bool isInHand;  
    [SerializeField] Transform rayPoint;
    [SerializeField] int damage;
    [SerializeField] private int MaxDistance = 200;

    private void Start()
    {
    }

    public void Fire()
    {
        print("! Activate");
        Debug.DrawRay(rayPoint.position, rayPoint.forward * 100, Color.blue, 10);

        if (Physics.Raycast(rayPoint.position, rayPoint.forward, out RaycastHit info, MaxDistance))
        {
            print($"! {info.collider.name}");
            if (info.collider.CompareTag("Zombie"))
            {
                info.collider.GetComponent<Zombie>().GetDamage(damage);
            }
        }
    }

    public void OnSelected()
    {
        print("! OnSelected");
        isInHand = true;
    }
    public void OnSelectedend()
    {
        print("! OnSelected");
        isInHand = false;
    }
    public void OnActivated()
    {
        print("! OnActivated");
    }
}
