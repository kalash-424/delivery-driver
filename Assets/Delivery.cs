using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool has_package;
    int count_package = 0;
    [SerializeField] Color32 noPackageColor = new Color32(255,255,255,255);
    [SerializeField] Color32 hasPackageColor = new Color32(0, 255, 255, 255);
    SpriteRenderer spriterenderer;
     void Start()
    {
         spriterenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Oo you bumped in!");
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "package" )
        {
            if (count_package == 0)
            {
                Debug.Log("Package picked up!");
                has_package = true;
                spriterenderer.color = hasPackageColor;
                Destroy(other.gameObject, 0.1f);
                count_package++;
                
            }
            else
            {
                Debug.Log("You already have a package, deliver it first");
            }

        }
        if (other.tag == "customer" && has_package )
        {
            Debug.Log("Package delivered!");
            has_package = false;
            spriterenderer.color = noPackageColor;
            count_package--;
        }

    }
}
