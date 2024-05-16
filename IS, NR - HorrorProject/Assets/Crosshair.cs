using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3f, layerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                hit.transform.name = HitWhat;
                Debug.Log(HitWhat);
            }
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            Physics.Raycast(Vector3.zero, Vector3.forward, 3f);
        }
    }
}
