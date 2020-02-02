using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cold : MonoBehaviour
{
    public Slider coldBar;
    public bool isWarming;
    public HatsSlot equipedHat;
    public JacketsSlot equipedJacket;
    public PantsSlot equipedPants;
    public ThirdPersonCamera cam;

    // Update is called once per frame
    void Update()
    {
        if (isWarming)
        {

        }
        else
        {
            coldBar.value += (Time.deltaTime / 10) * equipedJacket.item.coldMultiplier * equipedHat.item.coldMultiplier * equipedPants.item.coldMultiplier;
            if (coldBar.value >= 1)
            {
                cam.lockCursor = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
        
    }
}
