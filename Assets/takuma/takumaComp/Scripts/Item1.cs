using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    public GameObject[] ItemBoxs;


    public static Item1 instance;

    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        ItemBoxs[0].SetActive(false);
        ItemBoxs[1].SetActive(false);
        ItemBoxs[2].SetActive(false);

        
        SetItem();
        GetItem();
    }


    public void SetItem()
    {

        ItemBoxs[0].SetActive(true);

    }


   public bool UseItem()
    {

        if(ItemBoxs[0].activeSelf == true)
        {
            return true;
        }
        return false;
    }

    public void GetItem()
    {
        ItemBoxs[0].SetActive(false);
    }

}
