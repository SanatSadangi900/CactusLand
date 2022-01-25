using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicScene : MonoBehaviour
{
    public AudioClip newTrack;
    
    private MusicChange theAM;


    
    // Start is called before the first frame update
    void Start()
    {
        theAM = FindObjectOfType<MusicChange>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            theAM.ChangeMusic(newTrack);
        }
    }
}
