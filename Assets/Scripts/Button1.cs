
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{

    // Use this for initialization
    public GameObject VideoPlayer;
    public GameObject videScreen;
    WorldSpaceVideo1 video;
    private int count1 = 0;
    void Start()
    {
        video = VideoPlayer.GetComponent<WorldSpaceVideo1>();
        //videScreen.gameObject.SetActive(false);
    }
    public void PlayPauseVideo()
    {

        count1++;

        if (count1 % 2 == 1)
        {
            videScreen.gameObject.SetActive(true);
            video.play();
        }
        else
        {
            videScreen.gameObject.SetActive(false);
            video.pause();
        }
    }

    // Update is called once per frame

}
