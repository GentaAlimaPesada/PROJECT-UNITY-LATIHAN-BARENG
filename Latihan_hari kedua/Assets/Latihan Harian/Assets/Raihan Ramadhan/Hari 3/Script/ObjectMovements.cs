using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Method overload untuk menampilkan arah gerak object tanpa tambahan speed
    public void DebugLogMovement(Vector3 direction)
    {
        Debug.Log("Arah gerak object: " + direction);
    }

    // Method overload untuk menampilkan arah gerak object dengan tambahan speed
    public void DebugLogMovement(Vector3 direction, float speed)
    {
        Debug.Log("Arah gerak object dengan speed " + speed + direction);
    }

    void Update()
    {
        // Tombol Q digunakan Untuk menampilkan Print Object gerak tanpa Speed 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Vector3 direction = new Vector3(1, 4, 5);
            DebugLogMovement(direction);
        }

        // Tombol E digunakan Untuk menampilkan print Object gerak dengan Speed
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 direction = new Vector3(1, 2, 3);
            float speed = 5f;
            DebugLogMovement(direction, speed);
        }
    }
}
