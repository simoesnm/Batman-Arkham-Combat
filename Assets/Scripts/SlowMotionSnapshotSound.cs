using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class SlowMotionSnapshotSound : MonoBehaviour
{
    // Start is called before the first frame update
    // Instance of the FMOD snapshot.
    FMOD.Studio.EventInstance snapshotInstance;
    
    
    

    private void Start()
    {
        // Create an instance of the FMOD snapshot.
        snapshotInstance = FMODUnity.RuntimeManager.CreateInstance("snapshot:/SlowMotion");
        
        
    }

    void Update(){

       
    }



    // Call this function to apply the snapshot.
    public void OnEnable()
    {
        

            snapshotInstance.start();
            Debug.Log("Snapshot Activated");
        
         
    }



    void OnDisable(){

       

            snapshotInstance.release();
        
    }

    // Call this function to stop the snapshot.
    
}
