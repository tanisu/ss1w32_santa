using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
   
    public void OnRightArrow()
    {
        transform.localPosition = new Vector2(-1190, 0);
    }

    public void OnLiftArrow()
    {
        transform.localPosition = new Vector2(0, 0);
    }

}
