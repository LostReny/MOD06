using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    #region "Variables"
    [Header("direction")]
    public Vector3 dir;
    public int speed;
    #endregion

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed *Time.deltaTime);
    }
}
