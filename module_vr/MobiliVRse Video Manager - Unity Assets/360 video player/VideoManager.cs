using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public Material videoMat;
    public Material blackMat;
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void Play()
    {
        videoPlayer.Play();
    }

    public void Pause()
    {
        videoPlayer.Pause();
    }

    public void Stop()
    {
        videoPlayer.Stop();
    }

    public void URLToVideo(string url)
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = url;
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }

    private void VideoPlayer_prepareCompleted(VideoPlayer source)
    {
        Play();
    }

    // Update is called once per frame
    void Update()
    {


        //Mise sur pause
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pause();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Play();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Pause();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Play();
        }

        //Activation et désactivation de la skybox
        if (Input.GetKeyDown(KeyCode.L))
        {
            RenderSettings.skybox = videoMat;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            RenderSettings.skybox = blackMat;
        }

        //Lecture des vidéos
        if (Input.GetKeyDown(KeyCode.A))
        {
            URLToVideo("C:/Videos_360/A.MP4");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            URLToVideo("C:/Videos_360/B.MP4");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            URLToVideo("C:/Videos_360/E.MP4");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            URLToVideo("C:/Videos_360/R.MP4");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            URLToVideo("C:/Videos_360/T.MP4");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            URLToVideo("C:/Videos_360/Y.MP4");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            URLToVideo("C:/Videos_360/U.MP4");
        }
    }
}

