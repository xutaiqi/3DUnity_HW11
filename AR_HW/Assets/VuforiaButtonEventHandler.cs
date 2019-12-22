using System.Collections;
using System.Collections.Generic;
using Vuforia;
using System;
using UnityEngine;

public class VuforiaButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{

    // Use this for initialization
    public VirtualButtonBehaviour vb;
    public Animator ani;
    void Start()
    {
        vb.RegisterEventHandler(this);
        Debug.Log("start");
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb){

        ani.SetTrigger("Take off");

        Debug.Log("pressed");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb){
        ani.SetTrigger("Land");
        Debug.Log("released");
    }
}