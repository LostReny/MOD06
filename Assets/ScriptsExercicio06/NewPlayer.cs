using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    #region "Variables"
    [Header ("Movement")]

    public Vector3 dir;
    public int speed;

    public int life; 

    #endregion


    #region "Methods"

    public void Update(){
        if(Input.GetKey("left")){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        else if(Input.GetKey("right")){
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    #endregion
}
