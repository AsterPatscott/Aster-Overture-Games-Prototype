using UnityEngine;
using UnityEngine.Audio;
using System.Linq;
using System.Collections.Generic;
using TMPro;

//TODO: How are we keeping track of instruments? enum maybe?

//keeps track of player-placed audioclips in order to be retrieved by DAW Manager
[System.Serializable]
public class InstrumentSequence
{
    public Instrument Instrument;
    public GameObject[] Slots;
    public List<bool> sequence;
}



public class DAW : MonoBehaviour
{
    public int GuessesLeft = 3;
    public TextMeshProUGUI WinText;

    public InstrumentSequence[] correctSequences;
    public InstrumentSequence[] currentSequences;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Placeholder helper functions
    public void PH_GetInstruments()
    {

    }

    //Search the UI to get all clips of the associated instrument in order.
    public AudioClip[] PH_GetClipsinInstrument()
    {
        return null;
    }


    public void SubmitAnswer()
    {
        GetCurrentSequence();
        if(CheckForCorrectAnswer())
        {
            WinText.text = "Correct";
        }
        else
        {
            WinText.text = "Incorrect";
        }

    }


    public bool CheckForCorrectAnswer()
    {
        for (int i = 0; i < correctSequences.Length; i++)
        {
            if(!correctSequences[i].sequence.SequenceEqual(currentSequences[i].sequence))
            {
                
                return false;
            }
        }
        return true;
    }



    public void GetCurrentSequence()
    {
        //as of right now, this counts empty measures as measures full or rests, would need to change that later.

        foreach (InstrumentSequence currentSequence in currentSequences)
        {
            
            currentSequence.sequence.Clear();
            foreach (GameObject slot in currentSequence.Slots)
            {
                if(slot.transform.childCount>0)
                {
                    currentSequence.sequence.AddRange(slot.GetComponentInChildren<MeasureData>().Notes);
                }
                else
                {
                    currentSequence.sequence.AddRange(new bool[4]);
                }
                
            }
            
        }
    }

}
