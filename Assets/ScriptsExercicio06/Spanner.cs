using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanner : MonoBehaviour
{
   public GameObject prefab;

   public Vector3 Fdir;

   public NewPool newpool;

   public float timeToDestroy;


   private void SpannerItem(){
      prefab.GetComponent<Rigidbody>().AddForce(Fdir);

      var obj = newpool.GetPoolObject();
      obj.SetActive(true);
      obj.transform.SetParent(null);
   
   }

    private void Update() {
     if(Input.GetKeyDown(KeyCode.Space)){
            SpannerItem();
        }  
   }

   public void StartPrefab() {
        Invoke(nameof(FinishedUsed), timeToDestroy);
    } 

    private void FinishedUsed(){
        gameObject.SetActive(false);
    }

}
