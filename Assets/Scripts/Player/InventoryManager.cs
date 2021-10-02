using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] GameObject inventory;
    bool inventoryOpen;
    public delegate void OnInventorySwitch();  // delegate
    public event onInventorySwitch inventoryHandler;
    public GameObject Inventory { get => inventory; private set => inventory = value; }

    public void InventorySwitch()
    {
        inventoryOpen = !inventoryOpen;
        inventory.SetActive(inventoryOpen);
        invoke(inventoryHandler);
        Debug.Log(inventoryOpen);
    }
}
