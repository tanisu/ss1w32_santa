using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialLocker : MonoBehaviour
{
    //７つのボタンをクリックして、パスワードを揃えればクリア

    // ボタンの画像を取得
    public Image[] buttons;
    // 表示するマークを列挙
    enum Mark
    {
        だ,
        こ,
        ん,
        す,
        い,
        か,
        た,
        き,
        わ,
        さ
    }
    // 現在のマーク
    Mark[] currentMarks = { Mark.こ, Mark.こ, Mark.こ, Mark.こ, Mark.こ, Mark.こ, Mark.こ };
    Mark[] correctAnswerMarks = { Mark.だ, Mark.い, Mark.す, Mark.き, Mark.さ, Mark.ん, Mark.た };
    // 表示する画像の素材一覧
    public Sprite[] resourceSprites;

    public UnityEvent ClearEvent;

    public void OnMarkButton(int position)
    {
        // positionのマークを変更する
        ChangeMark(position);
        // positionの画像を表示する
        ShowMark(position);

        if (IsAllClearMark() == true)
        {
            Clear();
        }
    }
    void ChangeMark(int position)
    {
        currentMarks[position]++; // １つ次のマーク
        if (currentMarks[position] > Mark.さ)
        {
            currentMarks[position] = Mark.だ;
        }
    }
    void ShowMark(int position)
    {
        int index = (int)currentMarks[position]; // int化
        buttons[position].sprite = resourceSprites[index]; // 対応する画像を表示
    }

    bool IsAllClearMark()
    {
        for (int i = 0; i < currentMarks.Length; i++)
        {
            if (currentMarks[i] != correctAnswerMarks[i])
            {
                // １つでも違うものがあればクリアではない
                return false;
            }
        }
        //全て一致していたのでクリア
        return true;
       
    }

    void Clear()
    {
        //鍵1をパネル５の本に出したい
        Debug.Log("ロッカーが開いた");
        ClearEvent.Invoke();
    }

}
