using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody Rigid;
    // Start is called before the first frame update
    void Start()
    {
        Rigid = GetComponent<Rigidbody>();
        Rigid.velocity = new Vector3(0, 0, -9);

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 4;
        Rigid.velocity = Rigid.velocity.normalized * speed;

        if (Input.GetKeyDown(KeyCode.X))
        {
            Rigid.AddForce(new Vector3(0, -40, 0));
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject otherGameObject = collision.gameObject;
        Enemy hitenemy = otherGameObject.GetComponent<Enemy>();
        D� hitd� = otherGameObject.GetComponent<D�>();

        if (hitenemy != null)
        {
            hitenemy.TakeDamage();
        }
        if (hitd� != null)
        {
            transform.position = new Vector3(0, 5, -9);
        }



    }
}
