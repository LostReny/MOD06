using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    #region Collision
    // checking collision on time only 
    // parametros que mostram a colisão
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision Enter" + collision.gameObject.name);
        // destroi quando entrar em colisao
        Destroy(gameObject);
    }

    // checking collision every frame that´s collision is happening
    private void OnCollisionStay(Collision collision) {
        Debug.Log("Collision Stay" + collision.gameObject.name);
    }

    // checking when exit collision on time only 
    private void OnCollisionExit(Collision collision){
        Debug.Log("Collision Exit" + collision.gameObject.name);
    }
    #endregion

    #region Trigger

    // marca obj como trigger no seu collider unity
    // retira a gravidade
     
     private void OnTriggerEnter(Collider collider){
        Debug.Log("Trigger Enter" + collider.gameObject.name);
     }

     private void OnTriggerStay(Collider collider){
        Debug.Log("Trigger Stay" + collider.gameObject.name);
     }

     private void OnTriggerExit(Collider collider){
        Debug.Log("Trigger Exit" + collider.gameObject.name);
     }

    #endregion

}


