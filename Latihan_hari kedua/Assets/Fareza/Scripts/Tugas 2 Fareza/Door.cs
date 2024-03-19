using System.Collections;
using UnityEngine;
using GmMngrFareza;

public class Door : MonoBehaviour 
{
    [SerializeField] private int doorID;
    [SerializeField] private float moveDistance = 3f;

    private Vector3 originalPosition;
    private bool isOpen = false;

    private void Start() => originalPosition = transform.position;

    private void OnEnable() => GameManager.OnPlayerApproachingDoor += OnPlayerApproaching;
    private void OnDisable() => GameManager.OnPlayerApproachingDoor -= OnPlayerApproaching;

    private void OnPlayerApproaching(int approachingDoorID)
    {
        if (doorID == approachingDoorID && !isOpen)
            OpenDoor();
        else
            CloseDoor();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            GameManager.Instance.PlayerApproachingDoor(doorID);
    }

    private void OpenDoor()
    {
        isOpen = true;
        transform.Translate(Vector3.right * moveDistance);
        Debug.Log("Door with ID " + doorID + " is now open.");
    }

    private void CloseDoor()
    {
        isOpen = false;
        transform.position = originalPosition;
        Debug.Log("Door with ID " + doorID + " is now closed.");
    }
}