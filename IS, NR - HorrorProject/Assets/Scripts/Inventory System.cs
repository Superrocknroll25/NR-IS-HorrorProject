using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    List<string> InventorySpace = new List<string>();

    public void AddToInventory(string Item)
    {
        InventorySpace.Add(Item);
    }

}
