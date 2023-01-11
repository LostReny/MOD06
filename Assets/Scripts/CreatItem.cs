using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatItem : MonoBehaviour
{   
    #region Variables
    [Header ("Prefabs")]
    public GameObject prefab;

    [Header("RididbodyInteraction")]
    public Vector3 ForceDirection;


    #endregion  
    
    #region Instantiate 
    // Spawn o prefab
    // cria um objeto e devolve a referencia desse objeto 
    // instantiate - função para criar clones de gameObjects
    private void SpawnItem(){
        //GameObject obj = Instantiate(prefab, transform); - pode ser lido assim
        var obj = Instantiate(prefab, transform);

        // interagindo com o rigidbody - adicionando F 
        obj.GetComponent<Rigidbody>().AddForce(ForceDirection);

        // torque
        //obj.GetComponent<Rigidbody>().AddTorque(ForceDirection);

        //relative torque
        //obj.GetComponent<Rigidbody>().AddRelativeTorque(ForceDirection);

        //mover 
        //obj.GetComponent<Rigidbody>().MovePosition(ForceDirection);
    }
    #endregion

    #region key
    //ao apertar o botão usamos o método de spawn
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            SpawnItem();
        }  
    }

    #endregion
}
