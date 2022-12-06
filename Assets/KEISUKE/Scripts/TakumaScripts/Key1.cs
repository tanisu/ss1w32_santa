using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
    // ダイアルをクリアしたら、ロッカーをオープンにする：Key1オブジェクトを表示する
    public GameObject openObj;

    public void OpenKey()
    {
        openObj.SetActive(true);
    }
}
