using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceDiamond : MonoBehaviour
{
    private static Dictionary<GameObject, ResourceDiamond> instances = new Dictionary<GameObject, ResourceDiamond>();
    private int diamondCount = 0;
    public int generate = 10;
    public int intervalTime = 2 ;

    private void Awake()
    {
        if (!instances.ContainsKey(gameObject))
        {
            instances.Add(gameObject, this);
        }
        else
        {
            Destroy(gameObject);
        }

        // Start generating diamonds
        StartGeneratingDiamonds(generate, intervalTime);
    }

    private void Start()
    {
        ServiceLocator.RegisterService<ResourceDiamond>(this);
    }

    public static int GetTotalDiamondCount()
    {
        int totalDiamondCount = 0;
        foreach (KeyValuePair<GameObject, ResourceDiamond> instance in instances)
        {
            totalDiamondCount += instance.Value.diamondCount;
        }
        return totalDiamondCount;
    }

    private void StartGeneratingDiamonds(int diamondsPerInterval, float intervalSeconds)
    {
        StartCoroutine(GenerateDiamondsRoutine(diamondsPerInterval, intervalSeconds));
    }

    private IEnumerator GenerateDiamondsRoutine(int diamondsPerInterval, float intervalSeconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalSeconds);
            AddDiamonds(diamondsPerInterval);
        }
    }

    public void AddDiamonds(int amount)
    {
        diamondCount += amount;
        Debug.Log($"Added {amount} diamonds. Total diamonds: {diamondCount}");
    }

    public int GetDiamondCount()
    {
        return diamondCount;
    }
}
