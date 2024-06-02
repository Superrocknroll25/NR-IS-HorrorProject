using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    List<string> InventorySpace = new List<string>();

    public void AddToInventory(string Item)
    {
        if (!InventorySpace.Contains(Item))
        {
            InventorySpace.Add(Item);

            Debug.Log("Picked Up Item");
        }

        Debug.Log(InventorySpace[0]);
    }

}
