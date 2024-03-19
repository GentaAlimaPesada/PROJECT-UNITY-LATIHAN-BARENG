using System.Collections.Generic;

public class Fuel
{
    private List<IObserver> observers = new List<IObserver>();
    private int currentFuel = 50; // Default fuel
    private const int maxFuel = 100;
    private const int minFuel = 0;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void IncreaseFuel()
    {
        if (currentFuel < maxFuel)
        {
            currentFuel += 10;
            NotifyObservers();
        }
    }

    public void DecreaseFuel()
    {
        if (currentFuel > minFuel)
        {
            currentFuel -= 10;
            NotifyObservers();
        }
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.OnFuelChange(currentFuel);
        }
    }
}

public interface IObserver
{
    void OnFuelChange(int fuelAmount);
}
