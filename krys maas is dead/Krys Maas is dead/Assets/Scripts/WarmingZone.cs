using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarmingZone : MonoBehaviour
{
    public Cold cold;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            cold.coldBar.value -= (Time.deltaTime / 10);
            cold.isWarming = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cold.isWarming = false;
        }
    }
}
