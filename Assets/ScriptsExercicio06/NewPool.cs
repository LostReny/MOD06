using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPool : MonoBehaviour
{
    #region "Variables"
 [Header("Game Object")]
 public GameObject prefab;
 public List<GameObject> pooledObjects;

[Header("size")]
public int size = 20;
 #endregion


#region "Methods"

private void Awake() {
    StartThePool();
}


private void StartThePool(){
    pooledObjects = new List<GameObject>();

    for(int i = 0; i < size; i++){
        var obj = Instantiate(prefab, transform);
        obj.SetActive(false);
        pooledObjects.Add(obj);
    }
}

//take the next objetc available
public GameObject GetPoolObject(){
    for(int i = 0; i < size; i++){
        if (!pooledObjects[i].activeInHierarchy){
            return pooledObjects[i];
        }
    }
    return null;
}
#endregion
}
