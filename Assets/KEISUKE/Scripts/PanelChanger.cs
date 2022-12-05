using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;

    //パネルが何個あるか並べる
    enum Panel
    {
        Panel0,
        Panel1,
        Panel2,
        Panel3,
        Panel4,
        Panel5,
        Panel6,
        Panel7,

    }

    Panel currentPanel;
    //スタートはパネル１からスタート
    private void Start()
    {
        Show(Panel.Panel1);
    }

    //初期の場合矢印を一旦全部消す
    void HideArrows()
    {
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        backArrow.SetActive(false);
    }

    //各ボタンを押した場合
    public void OnRightButton()
    {
       switch(currentPanel)
        {
            case Panel.Panel0:
                Show(Panel.Panel1);
                break;
            case Panel.Panel1:
                Show(Panel.Panel2);
                break;
            case Panel.Panel2:
                Show(Panel.Panel3);
                break;

        }
    }
    public void OnLeftButton()
    {
        switch (currentPanel)
        {
            case Panel.Panel1:
                Show(Panel.Panel0);
                break;
            case Panel.Panel2:
                Show(Panel.Panel1);
                break;
            case Panel.Panel3:
                Show(Panel.Panel2);
                break;

        }
    }

        public void OnBackButton()
        {
        // Panel4 -> 0
        // Panel5 -> 1
        // Panel6 -> 2
        switch (currentPanel)
        {
            case Panel.Panel4:
                Show(Panel.Panel0);
                break;
            case Panel.Panel5:
                Show(Panel.Panel1);
                break;
            case Panel.Panel6:
                Show(Panel.Panel2);
                break;

        }


    }
    //closetをタップしたらパネル移動

    public void OnCloset()
    {
        Show(Panel.Panel4);
    }
    //本棚をタップしたらパネル移動
    public void OnBookShelf()
    {
        Show(Panel.Panel5);
    }
    //手紙触ったらパネル移動
    public void OnLetter()
    {
        Show(Panel.Panel6);
    }


        //どのパネルを表示させるのか
        void Show(Panel panel)
        {
        HideArrows();
        currentPanel = panel;
        switch (panel)
        {
            case Panel.Panel0:
                rightArrow.SetActive(true);
                transform.localPosition = new Vector2(0, 0);
                break;
            case Panel.Panel1:
                rightArrow.SetActive(true);
                leftArrow.SetActive(true);
                transform.localPosition = new Vector2(-1200, 0);
                break;
            case Panel.Panel2:
                rightArrow.SetActive(true);
                leftArrow.SetActive(true);
                transform.localPosition = new Vector2(-2400, 0);
                break;
            case Panel.Panel3:
                leftArrow.SetActive(true);
                transform.localPosition = new Vector2(-3600, 0);
                break;
            case Panel.Panel4:
                backArrow.SetActive(true);
                transform.localPosition = new Vector2(0, 800);
                break;
            case Panel.Panel5:
                backArrow.SetActive(true);
                transform.localPosition = new Vector2(-1200, 800);
                break;
            case Panel.Panel6:
                backArrow.SetActive(true);
                transform.localPosition = new Vector2(-2400, 800);
                break;
            case Panel.Panel7:
                backArrow.SetActive(true);
                transform.localPosition = new Vector2(0, 1600);
                break;
        }
        }
}
