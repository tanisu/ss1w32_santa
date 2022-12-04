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
            SoundManager.I.LoopSwitch();
        });
    }

    private void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SoundManager.I.PlayBGM(BGMSoundData.BGM.TEST);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SoundManager.I.PlayBGM(BGMSoundData.BGM.MAIN_SLOW);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundManager.I.PlaySE(SESoundData.SE.OPEN_DOOR);
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            SoundManager.I.PlaySE(SESoundData.SE.DRAWER);
        }
        if (Input.GetMouseButtonDown(0))
        {
            SoundManager.I.PlaySE(SESoundData.SE.BUTTON);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            SoundManager.I.PlaySE(SESoundData.SE.TOY_BOX);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SoundManager.I.PlaySE(SESoundData.SE.DISCOVER);
        }
    }
}
