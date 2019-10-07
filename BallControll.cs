using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = this.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Rb.velocity = new Vector3(0f, 0f, 0f);

            this.transform.position = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetKey (KeyCode.RightArrow))
        {
            Rb.AddForce(new Vector3(15f, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rb.AddForce(new Vector3(-15f, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rb.AddForce(new Vector3(0f, 0f, 15f));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rb.AddForce(new Vector3(0f, 0f, -15f));
        }

        if ((Input.GetKeyDown(KeyCode.LeftShift)) || (Input.GetKeyDown(KeyCode.RightShift)))
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            Vector3 velo = rb.velocity;
            rb.velocity = new Vector3(velo.x, 17f, velo.z);

        }

        if ((Input.GetKeyUp(KeyCode.LeftShift)) || (Input.GetKeyUp(KeyCode.RightShift)))
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            Vector3 velo = rb.velocity;

            if (velo.y > 0)
            {
                rb.velocity = new Vector3(velo.x, velo.y * 0.45f, velo.z);

            }
        }

    }

    void FixedUpdate()
    {
        if (this. transform.position.y < -150f)
        {
            Rb.velocity = new Vector3(0f, 0f, 0f);

                this.transform.position = new Vector3(0f, 0f, 0f);
        }
        
    }

}
