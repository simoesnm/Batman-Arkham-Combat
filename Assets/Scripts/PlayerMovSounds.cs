using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovSounds : MonoBehaviour
{
    [Header("FMOD Sounds")]
    
    //Jump

        private FMOD.Studio.EventInstance jumpInst;

        public FMODUnity.EventReference jumpEvent;

    //Swing

    private FMOD.Studio.EventInstance swingInst;

    public FMODUnity.EventReference swingEvent;

    //Vox

    private FMOD.Studio.EventInstance voxInst;

    public FMODUnity.EventReference voxEvent;

    [Header("FMOD Params")]

    public int kickpunch;
    public bool hitEnem = false;

    // EnemyScript enemyScript = GetComponent<EnemyScript>(); 
    
    

    void Start()
    {
        GameObject enemyObject = GameObject.Find("JammoPrefab (2)");
        EnemyScript enemyScript = enemyObject.GetComponent<EnemyScript>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerPunch(){

        kickpunch = 0;
        swingInst.start();
        swingInst.setParameterByName("Enemy", kickpunch);
        Debug.Log("Punch activated");

    }

    public void PlayerKick(){

        kickpunch = 1;
        swingInst.start();
        swingInst.setParameterByName("Enemy", kickpunch);

    }

    void PlayerJump(){

        jumpInst.start();
        Debug.Log("Jump is called");


    }

    void PlayerVox(){

        voxInst.start();

    }

    void PlayWalkFootsteps(){



    }

    void PlayRunFootsteps(){


    }
}
