using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class WorldSpaceVideo1 : MonoBehaviour
{

    private VideoPlayer videoPlayer;
    public void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Pause();
    }
    public void play()
    {
        videoPlayer.Play();
    }
    public void pause()
    {
        videoPlayer.Pause();
    }
}
