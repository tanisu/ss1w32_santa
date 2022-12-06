using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel1 : MonoBehaviour
{
    [SerializeField] Dial ClearDial;
    [SerializeField] StartGamen Gamen;
    public GameObject Paneldea;


    
    enum Panelde
    {
        Panel1,
        Panel2,
        Panel3,
        Panel4,
        Panel5,
        Panel6,
        Panel7,
        Panel8,
        Panel9,
        Panel10,
        Panel11,
        Panel12,
        Panel13,
        Panel14,

    }

    Panelde currentPanel;
    
  
    public void OnStart()
    {
        transform.localPosition = new Vector2(0,0);
        StartGamen.instance.OnTrueStart();
        currentPanel = Panelde.Panel1;
    }
    
    public void OnRightArrow()
    {
        

        switch (currentPanel)
        {
            case Panelde.Panel1:
                transform.localPosition = new Vector2(-1200, 0);
                currentPanel = Panelde.Panel2;
                break;


            case Panelde.Panel2:
                transform.localPosition = new Vector2(-2400, 0);
                currentPanel = Panelde.Panel3;
                break;

            case Panelde.Panel5:
                transform.localPosition = new Vector2(0, 0);
                currentPanel = Panelde.Panel1;
                break;

        }
    }

    public void OnLiftArrow()
    {
        switch (currentPanel)
        {
            case Panelde.Panel1:
                transform.localPosition = new Vector2(1200, 0);
                currentPanel = Panelde.Panel5;
                break;

            case Panelde.Panel2:
                transform.localPosition = new Vector2(0, 0);
                currentPanel = Panelde.Panel1;
                break;

            case Panelde.Panel3:
                transform.localPosition = new Vector2(-1200, 0);
                currentPanel = Panelde.Panel2;
                break;



        }
    }

    public void OnClickToyBox()
    {
        transform.localPosition = new Vector2(0, 800);
        currentPanel = Panelde.Panel6;
    }

    public void Action()
    {
        transform.localPosition = new Vector2(-1200, 800);
        currentPanel = Panelde.Panel7;

    }

    public void OnbackArrow()
    {
        switch (currentPanel)
        {
            case Panelde.Panel7:
                transform.localPosition = new Vector2(0, 0);
                currentPanel = Panelde.Panel1;
                break;

            

        }
    }



   






}
