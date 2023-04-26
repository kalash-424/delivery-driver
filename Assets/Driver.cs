using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   [SerializeField] float steerspeed = 250f;
   [SerializeField] float movingspeed = 15f;
    [SerializeField] float boostspeed = 20f;
    [SerializeField] float slowdownspeed = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * movingspeed * Time.deltaTime;
        transform.Rotate(0,0, -steeramount);
        transform.Translate(0, moveamount, 0);
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boost up")
        {
            Debug.Log("Boosted up!");
            movingspeed = boostspeed;
        }
        if (other.tag == "customer" && movingspeed == slowdownspeed)
        {
            movingspeed = 15f;
        }
        
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        movingspeed = slowdownspeed;
    }

}
