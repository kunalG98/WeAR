using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Custom : MonoBehaviour {

    public VideoPlayer videoPlayer;
    public GameObject quad;

    public GameObject stop;

    public void startVideo()
    {
        quad.SetActive(true);
        stop.SetActive(true);
        videoPlayer.Play();
    }

    public void pauseVideo()
    {
        videoPlayer.Pause();
    }

    public void stopVideo()
    {
        quad.SetActive(false);
        stop.SetActive(false);
        videoPlayer.Stop();


    }

	
}
