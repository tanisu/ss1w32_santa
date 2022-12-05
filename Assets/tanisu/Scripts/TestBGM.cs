using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestBGM : MonoBehaviour
{
    [SerializeField] Toggle loopToggle;
    void Start()
    {
        loopToggle.onValueChanged.AddListener(x=> {
            SoundManager.I.LoopSwitch(loopToggle.isOn);
        });
    }

}
