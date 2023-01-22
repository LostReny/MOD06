using System.Collections;
using System;
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

    public string tagToLook = "Enemy";

    public Action OnHitTarget; 
    #endregion

    // here we take put the dir, speed of the projectile 
    // we change the numbers in unity inspector 
    // translate in unity? moves the transform along the axis using dir * speed * timeDeltaTime
    // as our code in unity inspector z = 5, the movement will be aplied in z axis
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


    // method Invoke ?
    // is a fast method with time delay
    public void StartProjectiile() {
        Invoke(nameof(FinishedUsed), timeToDestroy);
    }
    
    private void FinishedUsed(){
        gameObject.SetActive(false);
        OnHitTarget = null;
    }

    // Method about going in collision with game object and destroing it 
    public void OnCollisionEnter (Collision collision){
        if (collision.transform.tag == tagToLook){
            Destroy(collision.gameObject);
            OnHitTarget?.Invoke(); 
            FinishedUsed();
        }
    }

}
