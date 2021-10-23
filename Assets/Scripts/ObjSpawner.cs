using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
    [SerializeField]
    private MovingObj objPrefab;

    public void spawnObj()
    {
        var newObj = Instantiate(objPrefab);

        if (MovingObj.LastObj != null && MovingObj.LastObj.gameObject != GameObject.Find("Start"))
        {
            newObj.transform.position = new Vector2(transform.position.x, 
                MovingObj.LastObj.transform.position.y + objPrefab.transform.localScale.y);
        }
        
    }
}
