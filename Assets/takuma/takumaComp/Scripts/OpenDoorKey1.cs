using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorKey1 : MonoBehaviour
{

    public GameObject Door;
    public GameObject OpenDoor;
    public static OpenDoorKey1 instance;

    public void Awake()
    {
        instance = this;
    }

    public void OnThis()
    {
        
        bool hasItem = Item1.instance.UseItem();
        if (hasItem == true)
        {
            
            gameObject.SetActive(false);
            
            Item1.instance.GetItem();

            Door.SetActive(false);
            OpenDoor.SetActive(true);

            CountDownTime01.instance.stoptime();
        }





    }

    
}
