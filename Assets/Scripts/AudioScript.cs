using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioClip WinClip;
    public AudioSource MusicSource;
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(winText.text == "You win!")
        {
            MusicSource.Stop();
            MusicSource.clip = WinClip;
            MusicSource.Play();
            winText.text = "You Win!!";
        }

        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
