using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinmatiqueDebut : MonoBehaviour
{
    public Cinemachine.CinemachineBrain cinemachineBrain;
    public GameObject canvas;
    public GameObject cinematique;
    public AudioSource musique;
    private bool fini = false;

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad >= 28f && fini == false)
        {
            cinematique.SetActive(false);
            cinemachineBrain.enabled = false;
            canvas.SetActive(true);
            musique.enabled = true;
            fini = true;
        }
    }
}
