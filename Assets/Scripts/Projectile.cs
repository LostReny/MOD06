using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    #region "Variables"
    [Header("direction")]
    public Vector3 dir;
    public int speed;

    public GameObject projectile;
    public float timeToDestroy;
    #endregion

    // here we take put the dir, speed of the projectile 
    // we change the numbers in unity inspector 
    void Update()
    {
        transform.Translate(dir * speed *Time.deltaTime);
    }

// in the method awake - before the script start
    /*void Awake(){
        if (projectile != null){
            Destroy(projectile, timeToDestroy);
        }*/

     /*    Destroy(projectile, timeToDestroy);
            
    }*/

    public void StartProjectiile() {
        Invoke(nameof(FinishedUsed), timeToDestroy);
    }

    private void FinishedUsed(){
        gameObject.SetActive(false);
    }
}
