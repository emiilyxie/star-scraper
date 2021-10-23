using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (MovingObj.CurrentObj != null)
            {
                print("stop");
                MovingObj.CurrentObj.Stop();
            }
            //FindObjectOfType<ObjSpawner>().spawnObj();
        }
    }
}
