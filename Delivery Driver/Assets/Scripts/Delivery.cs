using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 1f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bonk");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if we hit the package, print to console about package
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Got the Package!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
        }

        else if(hasPackage)
        {
            Debug.Log("You already have a package!");
        }

        //if we hit something else, print about that
        if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
