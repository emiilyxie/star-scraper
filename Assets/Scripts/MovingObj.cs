using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObj : MonoBehaviour
{
    public static MovingObj CurrentObj { get; private set; }
    public static MovingObj LastObj { get; private set; }
    public MovingObj StartObj;
    
    [SerializeField]
    private float moveSpeed = 1f;

    void OnEnable()
    {
        MovingObj StartObj = GameObject.Find("Start").GetComponent<MovingObj>();

        if (LastObj == null) 
        {
            LastObj = StartObj;
        }

        if (this != StartObj)
        {
            CurrentObj = this;
        }
    }

    internal void Stop()
    {
        moveSpeed = 0;
        float hangover = transform.position.x - LastObj.transform.position.x;
        
        float direction = hangover > 0 ? 1f : -1f;

        float newXSize = LastObj.transform.localScale.x - Mathf.Abs(hangover);


    }

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * moveSpeed;
    }
}
