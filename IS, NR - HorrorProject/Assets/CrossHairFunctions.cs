using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHairFunctions : MonoBehaviour
{
<<<<<<< Updated upstream
=======
    public GameObject Crosshair;
    RaycastHit hit;
    int layerMask = 1 << 9;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }
<<<<<<< Updated upstream

    // Update is called once per frame
    void Update()
    {
=======
    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(Crosshair.transform.position, transform.TransformDirection(Vector3.forward), out hit, 3f, layerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                    Debug.Log("You pressed " + hit.collider.gameObject.name);
            }
        }
>>>>>>> Stashed changes
        
    }
}
