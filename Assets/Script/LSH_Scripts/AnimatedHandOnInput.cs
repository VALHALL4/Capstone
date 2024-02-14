using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatedHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction; //����
    public InputActionProperty gripAnimationAction;

    public Animator handAnimator; //�ִϸ����� ��ü ����

    void Start()
    {
        
    }

    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue); //triggerValue���� ���� �ִϸ��̼� ���

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);


    }
}
