using UnityEngine;

using UnityEngine.UI;
using UnityEngine.Audio;

public enum InstrumentType
{
    snare, clap, hat, kick
};


public enum NoteType
{
    rest , quarter , eighth
}

[System.Serializable]
public class Instrument
{
    public InstrumentType type;
    public AudioClip clip;
}

public class Note
{ 
    public NoteType type;
    public float noteLength;
}

//This will need to be updated to be able to grab more info
public interface IReadMeasureData
{
    bool[] MeasureNotes { get; }
}


//We're just doing 4/4 for now so each beat should have 4 notes of the same length
public class Beat 
{
    public Note[] notes;
    public float noteLength;
}

[RequireComponent(typeof(AudioSource))]
public class DAWManagerScript : MonoBehaviour
{
    //holds all elements of the DAW and dynamically rearranges things based on level parameters like number of instruments and BPM
    //handles playing DAW Audio

    public AudioClip[] clipList;
    private int clipIndex;
    private AudioSource source;



    public GameObject DAWAnswers;
    public int BPM;
    private int beatLength;//how long is a beat in seconds, how long to wait on rest
    //TODO: sample rates?
    //use deltatime stuff for now

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playClip()
    {
        if (source.isPlaying)
        {
            return;
        }


    }

    //play the clips for beat1, then once it's done, beat2, etc. until reaching the end.
    public void playClipSequence()
    {

    }

    public Instrument[] GetInstruments()
    {
        return null;
    }

    public void CalculateNotesForInstrument()
    {

    }
  
}

