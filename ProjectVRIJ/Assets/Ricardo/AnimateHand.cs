using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{
    [SerializeField]
    private InputActionProperty pinch;
    [SerializeField]
    private InputActionProperty grip;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
     anim = this.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinch.action.ReadValue<float>();
        anim.SetFloat("Trigger", triggerValue);
        float gripValue = grip.action.ReadValue<float>();
        anim.SetFloat("Grip", gripValue);


    }
}
