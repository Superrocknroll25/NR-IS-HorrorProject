using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour
{

    public InventorySystem Inventory;

    public Camera RaycastCam;

    public float range = 4;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootRaycast();
        }
    }

    private void ShootRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(RaycastCam.transform.position, RaycastCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            if (hit.transform.name == "Stick")
            {
                Inventory.AddToInventory("Stick");
            }
        }
    }
}
