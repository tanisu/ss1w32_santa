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

    Mark[] currentMarks = { Mark.s1, Mark.s1, Mark.s1 };

    Mark[] SeikaiMarks = { Mark.s1, Mark.s1, Mark.s2 };


    public void OnMarkButton(int position)
    {
        ChangeMark(position);
        ShowMark(position);

        if (IsAllClearMarks() == true)
        {

            Clear();
           

        }
    }


    void ChangeMark(int position)
    {
        currentMarks[position]++;

        if(currentMarks[position] > Mark.s4)
        {
            currentMarks[position] = Mark.s1;
        }

    }

    void ShowMark(int position)
    {
        int index = (int)currentMarks[position];
        button[position].sprite = Sozai[index];

    }

    bool IsAllClearMarks()
    {

        if (SeikaiMarks[0] == currentMarks[0] &&
                SeikaiMarks[1] == currentMarks[1] &&
                SeikaiMarks[2] == currentMarks[2])
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
