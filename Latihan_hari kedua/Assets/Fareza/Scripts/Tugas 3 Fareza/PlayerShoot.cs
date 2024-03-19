using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour 
{
    private bool canShoot = true;
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E) && canShoot)
        {
            canShoot = false;
            EventManager.OnPlayerShoot?.Invoke();
            StartCoroutine(DelayShoot());
        }
    }

    IEnumerator DelayShoot()
    {
        float delayTime = 0.2f;
        yield return new WaitForSeconds(delayTime);
        canShoot = true;
    }
}