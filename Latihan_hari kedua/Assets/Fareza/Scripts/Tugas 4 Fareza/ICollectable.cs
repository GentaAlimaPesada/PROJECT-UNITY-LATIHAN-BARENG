/// <summary>
/// Interface untuk objek yang dapat dikumpulkan.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Mengumpulkan item.
    /// </summary>
    /// <param name="amount">Jumlah item yang dikumpulkan.</param>
    void CollectItem(int amount);    
}