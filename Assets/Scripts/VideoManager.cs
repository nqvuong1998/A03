using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{

    public GameObject videoPlayer;
    public GameObject bg, cv;
    VideoPlayer vp;

    // Use this for initialization
    void Start()
    {
        vp = videoPlayer.GetComponent<VideoPlayer>();
        vp.loopPointReached += EndReached;
        vp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndReached(vp);
        }
    }

    void EndReached(VideoPlayer vp)
    {
        videoPlayer.SetActive(false);
        bg.SetActive(true);
        cv.SetActive(true);
    }
}