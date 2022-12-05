using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet0 : MonoBehaviour
{
    // クリックした時に、鍵を持っていれば Openにする
    // 持っていなければログを出す
    public GameObject openObj;

    public void OnThis()
    {
        bool hasKey = ItemBox.instance.CanUseItem(ItemManager.Item.Key1);
        if (hasKey == true)
        {
            Open();
            ItemBox.instance.UseItem(ItemManager.Item.Key1);
        }
        else
        {
            Debug.Log("鍵がかかっている");
        }
    }

    void Open()
    {
        // 開いている画像を表示
        openObj.SetActive(false);
    }
}
