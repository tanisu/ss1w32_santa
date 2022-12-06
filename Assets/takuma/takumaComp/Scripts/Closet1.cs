using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet1 : MonoBehaviour
{
    [SerializeField] GameObject Obj;
    [SerializeField] GameObject ToyBox;

    public void OnClickObj()
    {
        gameObject.SetActive(false);
        Obj.SetActive(true);
        ToyBox.SetActive(true);
    }
}
