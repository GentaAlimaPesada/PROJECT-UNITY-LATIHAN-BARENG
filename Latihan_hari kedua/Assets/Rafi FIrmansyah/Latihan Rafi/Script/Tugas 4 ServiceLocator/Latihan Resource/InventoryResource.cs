using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryResource : MonoBehaviour
{
    public TextMeshProUGUI DiamondText;

    private void Update()
    {
        DisplayDiamondCount();
    }

    private void Start()
    {
        // Register the InventoryResource service
        ServiceLocator.RegisterService<InventoryResource>(this);
    }
    /// <summary>
    /// Method ini bertujuan untuk mengambil Total Diamond dari service <ResourceDiamond>
    /// </summary>
    public void DisplayDiamondCount()
    {
        ResourceDiamond resourceDiamond = ServiceLocator.GetService<ResourceDiamond>();
        if (resourceDiamond != null)
        {
            int totalDiamondCount = ResourceDiamond.GetTotalDiamondCount();
            DiamondText.text = "Diamond : " + totalDiamondCount.ToString();
            Debug.Log($"Current Total Diamond Count: {totalDiamondCount}");
        }
        else
        {
            Debug.LogError("ResourceDiamond service not found!");
        }
    }
}
