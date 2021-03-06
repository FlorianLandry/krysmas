﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public float range;
    public Interactable focus;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            pick();
        }
    }

    public void pick()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log("Hit !");
            Interactable interactable = hit.transform.GetComponent<Interactable>();
            if(interactable != null)
            {
                Debug.Log("Focus !");
                setFocus(interactable);
            }
        }
        
    }

    void setFocus(Interactable newFocus)
    {
        if(focus != newFocus)
        {
            if(focus != null)
            {
                focus.onDefocused(transform);
            }

            Debug.Log("focus focus !");
            focus = newFocus;
        }
        
        newFocus.OnFocused(transform);
    }

    public void removeFocus()
    {
        if(focus != null)
        {
            focus.onDefocused(transform);
            focus = null;
        }
        
    }
}
