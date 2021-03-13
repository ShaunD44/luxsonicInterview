using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int itemsCollected = 0;
    public static int totalItems = 3;
    public GameObject winScreen;
    public Text itemDisplay;

    void Update()
    {
        if (itemsCollected == totalItems)
        {
            //Debug.Log("well done!");
            winScreen.SetActive(true);
        }
        itemDisplay.text = "Items collected" +itemsCollected.ToString();
    }
}
