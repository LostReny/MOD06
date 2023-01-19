using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
 #region "Variables"
 [Header("Game Object")]
 public GameObject prefab;
 public List<GameObject> pooledObjects;

[Header("Amount")]
public int amount = 20;
 #endregion


#region "Methods"

private void Awake() {
    StartPool();
}


private void StartPool(){
    pooledObjects = new List<GameObject>();

    for(int i = 0; i < amount; i++){
        var obj = Instantiate(prefab, transform);
        obj.SetActive(false);
        pooledObjects.Add(obj);
    }
}

//take the next objetc available
public GameObject GetPoolEdObject(){
    for(int i = 0; i < amount; i++){
        if (!pooledObjects[i].activeInHierarchy){
            return pooledObjects[i];
        }
    }
    return null;
}
#endregion

}
