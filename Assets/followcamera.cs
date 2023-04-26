using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{
    [SerializeField] GameObject thecar;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thecar.transform.position + new Vector3(0,0,-2);
    }
}
