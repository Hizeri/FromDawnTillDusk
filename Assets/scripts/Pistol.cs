using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class Pistol : MonoBehaviour
{
    // [SerializeField] Vector3 selectedscale;
    // [SerializeField] Vector3 normalscale;
    bool isInHand = false;
    [SerializeField] Transform rayPoint;
    [SerializeField] int damage;
    [SerializeField] InputActionManager actionManager;

    private void Update()
    {
        if (actionManager.actionAssets[0].actionMaps[5].FindAction("Activate").triggered)
        {
            print("! Activate");
            Debug.DrawRay(rayPoint.position, rayPoint.forward*100, Color.blue, 10);

            if (Physics.Raycast(rayPoint.position, rayPoint.forward, out RaycastHit info, 200))
            {
                print($"! {info.collider.name}");
                if (info.collider.CompareTag("Zombie"))
                {
                    info.collider.GetComponent<Zombie>().GetDamage(damage);
                }
            }
        }
    }

    public void OnSelected()
    {
        print("! OnSelected");
        isInHand = true;
// transform.localScale = selectedscale;
    }
    public void OnSelectedend()
    {
        print("! OnSelected");
        isInHand = false;
        //transform.localScale = normalscale;
    }
    public void OnActivated()
    { 
        print("! OnActivated");
    }
}
