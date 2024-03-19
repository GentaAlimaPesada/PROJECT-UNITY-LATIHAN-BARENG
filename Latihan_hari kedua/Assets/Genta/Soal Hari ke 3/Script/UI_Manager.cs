using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private GameObject coinCounter;
    public static int coinCollected = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.GetComponent<Text>().text = coinCollected.ToString();
    }

    public void addCoinCollected()
    {
        coinCollected = coinCollected + 30;
    }

}
