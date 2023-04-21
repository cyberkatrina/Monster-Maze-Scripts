using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCutScene : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timeToStop;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);

        }
    }

}
