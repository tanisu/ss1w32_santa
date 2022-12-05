using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject[] ItemBoxs;


    public static Item instance;

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
        UseItem();
    }


    public void SetItem()
    {

        ItemBoxs[0].SetActive(true);

    }

    public void UseItem()
    {
        ItemBoxs[0].SetActive(false);
    }

}