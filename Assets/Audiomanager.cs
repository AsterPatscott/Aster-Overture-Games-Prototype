using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Audiomanager : MonoBehaviour
{

    public AudioClip[] soundClips;
    private int currentTrack;
    private AudioSource source;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSound()
    {
        if(source.isPlaying)
        {
            return;
        }
    }

    public void stopPlaying()
    {
        source.Stop();
    }

}
