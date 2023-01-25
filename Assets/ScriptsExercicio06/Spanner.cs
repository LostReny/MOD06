using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanner : MonoBehaviour
{
   public GameObject pObj;

   public Vector3 Fdir;

   public NewPool newpool;

   public float timeToDestroy;

   public float delayTime;

   public Transform startPoint;


   private void SpannerItem(){

      var obj = newpool.GetPoolObject();

    if(obj != null){
        obj.SetActive(true);
        obj.GetComponent<Rigidbody>().AddForce(Fdir);
        obj.transform.SetParent(null);
        obj.transform.position = startPoint.transform.position;
        //chamando a coroutina
         StartCoroutine(FineshedUsingObjectCoroutine(obj,timeToDestroy));
    }
     
   }

    private void Update() {
     if(Input.GetKeyDown(KeyCode.Space)){
            SpannerItem();
        }  
   }

    // utilizar Coroutine para desativar o objeto chamando o Set.Active
    private IEnumerator FineshedUsingObjectCoroutine(GameObject pObj, float delayTime){
        yield return new WaitForSeconds(delayTime);
        pObj.SetActive(false);
    }

}
