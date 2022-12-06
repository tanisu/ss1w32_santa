using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public enum Item
    {
        Key1,
        Key2,
        TrashBox,
        Woods,
        Cane,
    }
    public Item item;

    // クリックされた時に、
    public void OnTihs()
    {
        // ・消す
        gameObject.SetActive(false);

        // ・ItemBoxに追加する
        ItemBox1.instance.SetItem(item);
    }
}
