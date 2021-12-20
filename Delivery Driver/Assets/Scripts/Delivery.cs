using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bonk");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if we hit the package, print to console about package
        if (collision.tag == "Package")
        {
            Debug.Log("Got the Package!");
        }

        //if we hit something else, print about that
        if(collision.tag == "Customer")
        {
            Debug.Log("Delivered");
        }
    }
}
