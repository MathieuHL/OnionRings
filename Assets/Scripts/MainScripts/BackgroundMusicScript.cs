using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour
{
    private static BackgroundMusicScript backgroundMusic;

    private void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            //DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
