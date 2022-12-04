using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour
{
    [SerializeField] GameObject Obj;
    
    public void OnClickObj()
    {
        gameObject.SetActive(false);

       
    }
}
