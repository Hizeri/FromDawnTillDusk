using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputsVR : MonoBehaviour
{
    [SerializeField] private Animator handAnimator;
    [SerializeField] private InputActionProperty gripAction;
    [SerializeField] private InputActionProperty triggerAction;

    // Update is called once per frame
    void Update()
    {
        float gripValue = gripAction.action.ReadValue<float>();
        float triggerValue = triggerAction.action.ReadValue<float>();

        //handAnimator.SetFloat("Grip", gripValue);
        //handAnimator.SetFloat("Trigger", triggerValue);

        handAnimator.SetFloat("Trigger", gripValue);
        handAnimator.SetFloat("Grip", triggerValue);
    }
}