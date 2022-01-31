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
    
    private void Awake()
    {
        inputcontroller = new Imputcontroleer();
        inputcontroller.moverse.run.started += context => { running = true; };
        inputcontroller.moverse.run.canceled += context => { running = false; };
        inputcontroller.moverse.move.performed += context => stickl = context.ReadValue <Vector2>();
        inputcontroller.moverse.move.canceled += context => stickl = Vector2.zero;
        inputcontroller.moverse.straffl.performed += context => triggerl = context.ReadValue<float>();
        inputcontroller.moverse.straffl.canceled += context => triggerl = 0f;
        inputcontroller.moverse.straffr.performed += context => triggerr = context.ReadValue<float>();
        inputcontroller.moverse.straffr.canceled += context => triggerr = 0f;
        

    }
    // Update is called once per frame
    void Update()
    {

        DetectarMovL();
        
        
        
        if(running && stickl.y > 0)
        {
            Correr();

        }
        else if(straffing && stickl.y == 0)
        {
            MovL();
     
        }
        else
        {
            Walky();
        }
        
        

        transform.Rotate(new Vector3(0F, stickl.x * 0.8f, 0f));
    }

    private void OnEnable()
    {
        inputcontroller.Enable();
    }

    private void OnDisable()
    {
        inputcontroller.Disable();
    }
    void DetectarMovL()
    {
        if (triggerl != 0 || triggerr != 0)
        {
            straffing = true;
        }
        else
        {
            straffing = false;
        }
        
    }
    void Correr()
    {
        animator.SetBool("run",running);
        animator.SetBool("straffing",  false);
        speed = 6f;
        dir = transform.TransformDirection(Vector3.forward);
        cc.SimpleMove(dir * speed * stickl.y);
    }
    void MovL()

    {
        float strafe = triggerr - triggerl;
        animator.SetBool("straffing",  true);
        animator.SetBool("run", false);
        animator.SetFloat("strafinf", strafe);
        dir = transform.TransformDirection(Vector3.right);
        speed = 1.8f;

        cc.SimpleMove(dir * strafe * speed);
    }
    void Walky()
    {
        animator.SetBool("straffing", false);
        animator.SetBool("run", false);
        animator.SetFloat("speed", stickl.y);

        if (stickl.y > 0)
        {
            speed = 2f;
        }
        else
        {
            speed = 0.8f;
        }

        dir = transform.TransformDirection(Vector3.forward);

        cc.SimpleMove(dir * speed * stickl.y);

    }

}
   