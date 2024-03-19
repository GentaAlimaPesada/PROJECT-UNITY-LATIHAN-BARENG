using UnityEngine;
using UnityEngine.UI;

public class UIFuelDisplay : MonoBehaviour, IObserver
{
    public Text fuelText;

    public void OnFuelChange(int fuelAmount)
    {
        fuelText.text = "Fuel: " + fuelAmount.ToString();
    }
}
