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

    //Footsteps

    public FMOD.Studio.EventInstance footstepInst;

    public FMODUnity.EventReference footstepEvent;

    //Landing

    public FMOD.Studio.EventInstance landingInst;

    public FMODUnity.EventReference landingEvent;

    //Slow Motion

    public FMOD.Studio.EventInstance slowInst;

    public FMODUnity.EventReference slowEvent;

    [Header("FMOD Params")]

    public int kickpunch;
    public bool hitEnem = false;
    public bool playerAttack = false;
    CombatScript combatScript;
    //EnemyScript enemyScript;

  

    // EnemyScript enemyScript = GetComponent<EnemyScript>(); 
    
    

    void Start()
    {
        GameObject enemyObject = GameObject.Find("JammoPrefab (2)");
        EnemyScript enemyScript;
        swingInst = FMODUnity.RuntimeManager.CreateInstance(swingEvent);
        attackInst = FMODUnity.RuntimeManager.CreateInstance(attackEvent);
        landingInst = FMODUnity.RuntimeManager.CreateInstance(landingEvent);
        footstepInst = FMODUnity.RuntimeManager.CreateInstance(footstepEvent);
        jumpInst = FMODUnity.RuntimeManager.CreateInstance(jumpEvent);
        slowInst = FMODUnity.RuntimeManager.CreateInstance(slowEvent);
        Cursor.visible = false;
        
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
        playerAttack = true;


    }
    

   public  void PlayerJump(){

        jumpInst.start();
        Debug.Log("Jump is called");


    }

    void PlayerVox(){

        voxInst.start();

    }

    void PlayLanding(){

        landingInst.start();

    }

    void PlayRunFootsteps(){

        footstepInst.start();
    }

    public void SlowMotion(){

        slowInst.start();

        // if(combatScript.HitEvent().noEnemies = false){


        //     slowInst.release();
        // }

    }
}
