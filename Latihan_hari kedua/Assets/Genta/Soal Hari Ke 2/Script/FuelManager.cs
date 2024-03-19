using UnityEngine;

public class FuelManager : MonoBehaviour
{
    private Fuel fuel;

    void Start()
    {
        fuel = new Fuel();
        UIFuelDisplay uiFuelDisplay = FindObjectOfType<UIFuelDisplay>();
        fuel.AddObserver(uiFuelDisplay);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fuel.IncreaseFuel();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            fuel.DecreaseFuel();
        }
    }
}
