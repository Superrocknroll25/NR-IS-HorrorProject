using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    int layerMask = 1 << 10;
    RaycastHit hit;
    public string HitWhat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3f, layerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                hit.collider.name = HitWhat;
                Debug.Log(HitWhat);
            }
        }
        
    }
}
