using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatedHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction; //공부
    public InputActionProperty gripAnimationAction;

    public Animator handAnimator; //애니메이터 객체 저장

    void Start()
    {
        
    }

    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue); //triggerValue값에 따라 애니메이션 재생

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);


    }
}
