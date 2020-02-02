using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObjet : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f, 0f, 1f);
    }
}
