using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string namaItem;
    public TypeItem tipeItem;
    public Rarity rarity; // type item
    public GameObject itemPrefab; // Reference to the prefab you want to instantiate
    public Transform[] inventorySlots; // Array to store slots

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Example: Use the first slot for testing
        if (Input.GetKeyDown(KeyCode.U))
        {
            UseItem();
        }
    }

    public void UseItem()
    {

        Debug.Log("Anda Memakai Item : " + namaItem);
        Destroy(gameObject);
    }

    public void BuyItem()
    {
        // Loop through each slot to find an empty slot
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            Transform currentSlot = inventorySlots[i];

            // Check if the slot is full
            if (!IsSlotFull(currentSlot))
            {
                Debug.Log("Anda telah membeli " + namaItem);
                Debug.Log("Rarity : " + rarity + " Item : " + tipeItem);

                // Instantiate the itemPrefab as a child of the current slot
                GameObject newItem = Instantiate(itemPrefab, currentSlot.position, Quaternion.identity);

                // Adjust the position to be at the center of the slot
                newItem.transform.SetParent(currentSlot, false);
                newItem.transform.localPosition = Vector3.zero;

                return; // Exit the loop after instantiating the item
            }
        }

        // If all slots are full, handle the full inventory case
        Debug.Log("Inventory Full!");
    }

    private bool IsSlotFull(Transform slot)
    {
        // Check if the slot is full by comparing the child count with a maximum limit
        int maxItems = 1; // Change this to the maximum number of items allowed in each slot
        return slot.childCount >= maxItems;
    }
}

public enum TypeItem
{
    Potion,
    Weapon,
    Skills,
    Armor
}

public enum Rarity
{
    Normal,
    Rare,
    Epic,
    Legendary
}
