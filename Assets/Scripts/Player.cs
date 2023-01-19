using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    #region Variables
    [Header("Direction and velocity")]
    public Vector3 dir;
    public int speed;

    [Header("GameObject")]
    public GameObject Projectile;
    public Transform Shotter;
    
    #endregion

    #region Method movement input
    // if we press the left arrow - it will move to the left | the right arrow is the same thing
    // why it use speed and Time.delta time? - Unity time execution 
    //speed is suppose to be a variable? - yes - we use int to make a velocity in unity inspector 
    // GetKey - movement will be executed while pressing the button
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
     #endregion   

    #region Shotting
    if(Input.GetMouseButtonDown(0)){
        SpawnItem();
        Debug.Log("MouseButton");
    }  
    #endregion
    }

    #region Instantiate
    public void SpawnItem(){
        var obj = Instantiate(Projectile);
        obj.transform.position = Shotter.transform.position;
    }
    #endregion

}
