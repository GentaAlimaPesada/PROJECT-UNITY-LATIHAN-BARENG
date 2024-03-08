using UnityEngine;

public class PlayerJump : MonoBehaviour 
{
    private bool grounded;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
            EventManager.OnPlayerJump?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground"))
            grounded = true;
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground"))
            grounded = false;
    }
}