using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGamen : MonoBehaviour
{

    public GameObject[] UI;
   
    public static StartGamen instance;

    public void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UI[0].SetActive(false);
        UI[1].SetActive(false);
        
    }

    public void OnTrueStart()
    {
        UI[0].SetActive(true);
        UI[1].SetActive(true);
    }

}
