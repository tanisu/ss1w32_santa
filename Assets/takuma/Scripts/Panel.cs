using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
   
    public void OnRightArrow()
    {
        transform.localPosition = new Vector2(-2000, 0);
    }

    public void OnLiftArrow()
    {
        transform.localPosition = new Vector2(0, 0);
    }

}
