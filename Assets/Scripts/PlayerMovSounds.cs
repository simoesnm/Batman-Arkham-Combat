using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovSounds : MonoBehaviour
{
    [Header("FMOD Sounds")]
    
    //Jump

        public FMOD.Studio.EventInstance jumpInst;

        public FMODUnity.EventReference jumpEvent;

    //Swing

    public FMOD.Studio.EventInstance swingInst;

    public FMODUnity.EventReference swingEvent;

    //Attack

    public FMOD.Studio.EventInstance attackInst;

    public FMODUnity.EventReference attackEvent;

    //Vox

    public FMOD.Studio.EventInstance voxInst;

    public FMODUnity.EventReference voxEvent;

    [Header("FMOD Params")]

    public int kickpunch;
    public bool hitEnem = false;

    // EnemyScript enemyScript = GetComponent<EnemyScript>(); 
    
    

    void Start()
    {
        GameObject enemyObject = GameObject.Find("JammoPrefab (2)");
        EnemyScript enemyScript = enemyObject.GetComponent<EnemyScript>();
        swingInst = FMODUnity.RuntimeManager.CreateInstance(swingEvent);
        attackInst = FMODUnity.RuntimeManager.CreateInstance(attackEvent);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerWoosh(){

        
        swingInst.start();
        swingInst.setParameterByName("Enemy", 0);
        Debug.Log("Attack activated");

    }
    
    public void PlayerAttack(){

        
        attackInst.start();
        attackInst.setParameterByName("Enemy", 1);
        Debug.Log("Attack activated");

    }
    

   public  void PlayerJump(){

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
