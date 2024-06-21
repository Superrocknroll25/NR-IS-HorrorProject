using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    List<string> InventorySpace = new List<string>();

    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;

    private Image Slot1Image;
    private Image Slot2Image;
    private Image Slot3Image;
    private Image Slot4Image;

    private void Start()
    {
        Slot1Image = Slot1.GetComponent<Image>();
        Slot2Image = Slot2.GetComponent<Image>();
        Slot3Image = Slot3.GetComponent<Image>();
        Slot4Image = Slot4.GetComponent<Image>();
    }

    public void AddToInventory(string Item, Sprite Sprite)
    {
        if (!InventorySpace.Contains(Item))
        {
            InventorySpace.Add(Item);

            if (Slot1Image.sprite == null)
            {
                Slot1Image.sprite = Sprite;
            }
        }
    }

}
