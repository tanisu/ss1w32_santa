using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyBox : MonoBehaviour
{
    [SerializeField] GameObject OpenToyBox; 

    public void OnClickObj()
    {
        gameObject.SetActive(true);
    }

}
