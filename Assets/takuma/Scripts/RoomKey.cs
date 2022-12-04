using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomKey : MonoBehaviour
{
    public void OnThis()
    {
        gameObject.SetActive(false);
        Item.instance.SetItem();
    }

}
