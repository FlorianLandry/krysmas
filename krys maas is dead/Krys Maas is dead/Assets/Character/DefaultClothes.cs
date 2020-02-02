using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultClothes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Find("Bonnet").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("CacheOreilles").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("PantalonSki").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("PantalonDeRando").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("Buste").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("Veste").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("VesteHiver").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("VesteSki").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("HautDeForme").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("PantalonSki").gameObject.GetComponent<Renderer>().enabled = false;

    }

    void ChangeClothes()
    {
        gameObject.transform.Find("Bonnet").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("CacheOreilles").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("PantalonSki").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("PantalonDeRando").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("Buste").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("Veste").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("VesteHiver").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("VesteSki").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("HautDeForme").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("PantalonSki").gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.Find("Bras").gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.transform.Find("Mains").gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.transform.Find("Torse").gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.transform.Find("Jambes").gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.transform.Find("Pieds").gameObject.GetComponent<Renderer>().enabled = true;
    }
}
