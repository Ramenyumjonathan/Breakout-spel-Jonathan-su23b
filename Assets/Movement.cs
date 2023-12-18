using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody monridigibody;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 3, -9);

        monridigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))

        {

            monridigibody.AddForce(new Vector3(25, 0, 0));

        }

        if (Input.GetKey(KeyCode.LeftArrow))

        {

            monridigibody.AddForce(new Vector3(-25, 0, 0));

        }
    }
}
