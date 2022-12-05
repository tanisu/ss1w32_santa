using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorKey : MonoBehaviour
{

    public GameObject Door;
    public GameObject OpenDoor;
    public static OpenDoorKey instance;

    public void Awake()
    {
        instance = this;
    }

    public void OnThis()
    {
        
        bool hasItem = Item.instance.UseItem();
        if (hasItem == true)
        {
            
            gameObject.SetActive(false);
            
            Item.instance.GetItem();

            Door.SetActive(false);
            OpenDoor.SetActive(true);

            CountDownTime1.instance.stoptime();
        }





    }

    
}
