using UnityEngine;

//this class keeps track of the data needed to read when to play sound and when not to.
//for now, it just tells us if we are or are not playing for every beat
public class MeasureData : MonoBehaviour, IReadMeasureData
{
    [SerializeField]
    public bool[] Notes;
 
    
    public bool[] MeasureNotes 
    {
        get 
        {
            return Notes;
        } 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //TODO: Change color of squares based on bools
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
