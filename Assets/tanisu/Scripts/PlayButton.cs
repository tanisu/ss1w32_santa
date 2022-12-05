using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public SESoundData.SE SE_Type;
    public BGMSoundData.BGM BGM_Type;

    public void PlaySE()
    {
        SoundManager.I.PlaySE(SE_Type);
    }

    public void PlayBGM()
    {
        SoundManager.I.PlayBGM(BGM_Type);
    }
}

