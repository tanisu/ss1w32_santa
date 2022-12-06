using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomKey1 : MonoBehaviour
{
    public void OnThis()
    {
        gameObject.SetActive(false);
        Item1.instance.SetItem();
    }

   
}



