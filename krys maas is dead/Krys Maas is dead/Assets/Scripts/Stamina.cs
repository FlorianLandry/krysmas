using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Slider stamina;
    private bool tired = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(tired == false)
        {
            if (Input.GetKey(KeyCode.LeftShift) && stamina.value > 0)
            {
                playerMovement.speed = 10f;
                stamina.value -= (Time.deltaTime / 4);
            }
            if (stamina.value <= 0)
            {
                tired = true;
            }
            if(!Input.GetKey(KeyCode.LeftShift))
            {
                playerMovement.speed = 5f;
                stamina.value += (Time.deltaTime / 10);
            }
        }
        else
        {
            playerMovement.speed = 5f;
            if (stamina.value <= 0.5f)
            {
                stamina.value += (Time.deltaTime / 10);
            }
            else
            {
                tired = false;
            }
            
        }
        
    }
}
