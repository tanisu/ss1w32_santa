using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Dial : MonoBehaviour
{
    public Image[] button;
    public Sprite[] Sozai;
    public UnityEvent ClearEvent;


    enum Mark
    {
        s1,
        s2,
        s3,
        s4,
    }

    Mark[] currentMarks1 = { Mark.s1, Mark.s1, Mark.s1 };

    Mark[] SeikaiMarks1 = { Mark.s1, Mark.s1, Mark.s2 };


    public void OnMarkButton1(int position)
    {
        ChangeMark1(position);
        ShowMark1(position);

        if (IsAllClearMarks() == true)
        {

            Clear();
           

        }
    }


    void ChangeMark1(int position)
    {
        currentMarks1[position]++;

        if(currentMarks1[position] > Mark.s4)
        {
            currentMarks1[position] = Mark.s1;
        }

    }

    void ShowMark1(int position)
    {
        int index = (int)currentMarks1[position];
        button[position].sprite = Sozai[index];

    }

    bool IsAllClearMarks()
    {

        if (SeikaiMarks1[0] == currentMarks1[0] &&
                SeikaiMarks1[1] == currentMarks1[1] &&
                SeikaiMarks1[2] == currentMarks1[2])
        {
            return true;
        }
        return false;
    }


    void Clear()
    {

        ClearEvent.Invoke();
       
    }




}
