using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField] Dial ClearDial;
    [SerializeField] StartGamen Gamen;

    enum Panelde
    {
        Panel1,
        Panel2,
        Panel3,
        Panel4,
        Panel5,
        Panel6,
        Panel7,

    }

    Panelde currentPanel;

  
    public void OnStart()
    {
        transform.localPosition = new Vector2(0,0);
        currentPanel = Panelde.Panel1;
        StartGamen.instance.OnTrueStart();

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

        }
    }
        public void OnLiftArrow()
        {
          
        switch (currentPanel)
        {
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
            currentPanel = Panelde.Panel5;
        }

        public void Action()
        {
            transform.localPosition = new Vector2(-1200, 800);
            currentPanel = Panelde.Panel6;

        }
        public void OnbackArrow()
        {
            switch (currentPanel)
            {
                case Panelde.Panel2:
                    transform.localPosition = new Vector2(0, 0);
                    break;

                case Panelde.Panel3:
                    transform.localPosition = new Vector2(-1190, 0);
                    break;

                case Panelde.Panel5:
                    transform.localPosition = new Vector2(0, 0);
                    break;
            }
        }

    public void Nazotoki()
    {
        transform.localPosition = new Vector2(0, 0);
       
    }


    }
