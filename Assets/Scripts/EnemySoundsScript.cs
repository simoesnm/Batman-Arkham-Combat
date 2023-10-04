using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;

public class EnemySoundsScript : MonoBehaviour
{

    //Enemy Vox
    public FMOD.Studio.EventInstance enemyvoxInst;
    public FMODUnity.EventReference enemyvoxEvent;

    public string voxParam = "EnemyState";
   // public string voxObj;

    public GameObject voxSoundObj;


    //Walk

        public FMOD.Studio.EventInstance enemyWalkInst;

        public FMODUnity.EventReference enemyWalkEvent;

     //Attack

        public FMOD.Studio.EventInstance enemyAttackInst;

        public FMODUnity.EventReference enemyAttackEvent;


    //Head Hit

        public FMOD.Studio.EventInstance enemHeadHitInst;

        public FMODUnity.EventReference enemHeadHitEvent;

        //Death

        public FMOD.Studio.EventInstance enemDeathInst;

        public FMODUnity.EventReference enemDeathEvent;

    //Flying BAck

        public FMOD.Studio.EventInstance enemFlyingBackInst;

        public FMODUnity.EventReference enemFlyingBackEvent;

    
    //FMOD Params
    public int enemyMovement;
    public int enemyState;
    public bool enemyWorking;
    

   

    //Referenced Scripts
    EnemyScript enemyScript;

    void Awake(){

       

    }

    // Start is called before the first frame update
    public void Start()
    {
        //enemyMovement = 0;
        //enemyState = 0;
        enemyWalkInst = FMODUnity.RuntimeManager.CreateInstance(enemyWalkEvent);
        enemHeadHitInst = FMODUnity.RuntimeManager.CreateInstance(enemHeadHitEvent);
        enemDeathInst = FMODUnity.RuntimeManager.CreateInstance(enemDeathEvent);
        enemFlyingBackInst = FMODUnity.RuntimeManager.CreateInstance(enemFlyingBackEvent);
        enemyAttackInst = FMODUnity.RuntimeManager.CreateInstance(enemyAttackEvent);
        enemyvoxInst = FMODUnity.RuntimeManager.CreateInstance(enemyvoxEvent);

        // enemyvoxInst.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.transform));
        // FMODUnity.RuntimeManager.AttachInstanceToGameObject(enemyvoxInst, this.transform);

        enemyWalkInst.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.transform));
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(enemyWalkInst, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyFootsteps(){

        enemyWalkInst.start();
        enemyWalkInst.release();
    }

    public void EnemyVox(){

            

            // enemyvoxInst.setParameterByName(voxParam, enemyState);
            
                
            // enemyState = 1;
            enemyvoxInst.start();
        
            //enemyvoxInst.release();
            Debug.Log("Normal script worked"); 

    }

    void EnemHeadHit(){

        enemHeadHitInst.start();
    }

    void EnemAttack(){

        enemyAttackInst.start();
    }

    void EnemDeath(){

        enemHeadHitInst.start();

        enemHeadHitInst.release();

    }

    void FlyingBack(){

        enemFlyingBackInst.start();
    }

    

}
