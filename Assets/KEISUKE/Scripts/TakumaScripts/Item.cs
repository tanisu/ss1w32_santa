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

        
        SetItem1();
        UseItem1();
    }


    public void SetItem1()
    {

        ItemBoxs[0].SetActive(true);

    }

    public void UseItem1()
    {
        ItemBoxs[0].SetActive(false);
    }

}
