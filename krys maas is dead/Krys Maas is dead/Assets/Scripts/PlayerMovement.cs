using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpingForce;
    private bool jumping = false;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        jumping = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 v = Camera.main.transform.right;
            v.y = 0f;
            transform.position += v * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Vector3 v = Camera.main.transform.right;
            v.y = 0f;
            transform.position -= v * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 v = Camera.main.transform.forward;
            v.y = 0f;
            transform.position += v * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 v = Camera.main.transform.forward;
            v.y = 0f;
            transform.position -= v * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumping == false)
        {
            player.GetComponent<Rigidbody>().velocity = Vector3.up * jumpingForce;
            jumping = true;
        }

    }
}
