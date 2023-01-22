using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanner : MonoBehaviour
{
   public GameObject prefab;

   public Vector3 Fdir;

   private void SpannerItem(){
    var obj = Instantiate(prefab, transform);

    obj.GetComponent<Rigidbody>().AddForce(Fdir);
   }

    private void Update() {
     if(Input.GetKeyDown(KeyCode.Space)){
            SpannerItem();
        }  
   }
}
