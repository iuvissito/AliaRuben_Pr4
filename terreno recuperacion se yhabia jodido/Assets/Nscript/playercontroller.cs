using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Imputcontroleer inputcontroller;
    Animator animator;
    bool running = false;
    Vector2 stickl;
    float triggerl;
    float triggerr;
    bool straffing;
    float speed;
    Vector3  dir;
    CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
        speed = 2f;
        
    }
    private void OnEnable()
    {
        inputcontroller.Enable();
    }

    private void OnDisable()
    {
        inputcontroller.Disable();
    }
    private void Awake()
    {
        inputcontroller = new Imputcontroleer();
        inputcontroller.moverse.run.started += context => { running = true; };
        inputcontroller.moverse.run.canceled += context => { running = false; };
        inputcontroller.moverse.move.performed += context => stickl = context.ReadValue <Vector2>();
        inputcontroller.moverse.move.canceled += context => stickl = Vector2.zero;
        inputcontroller.moverse.straffl.performed += context => triggerl = context.ReadValue<float>();
        inputcontroller.moverse.straffl.canceled += context => triggerl = 0f;
        inputcontroller.moverse.straffr.performed += context => triggerl = context.ReadValue<float>();
        inputcontroller.moverse.straffr.canceled += context => triggerl = 0f;

    }
    // Update is called once per frame
    void Update()
    {
        float strafe = triggerr - triggerl;
        if (strafe != 0)
        {
            animator.SetBool("straffing", straffing = true);
        }
        else
        { 
            animator.SetBool("straffing", straffing = false);
        }
        animator.SetBool("run", running);
        animator.SetFloat("speed", stickl.y);
        dir = transform.TransformDirection(Vector3.forward);
        cc.SimpleMove(dir * speed * stickl);
    }
    
}
   