using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObj : MonoBehaviour
{
    public static MovingObj CurrentObj { get; private set; }
    public static MovingObj LastObj { get; private set; }
    
    [SerializeField]
    private float moveSpeed = 1f;

    void OnEnable()
    {
        print("call onenable");
        if (LastObj == null) 
        {
            LastObj = GameObject.Find("Start").GetComponent<MovingObj>();
        }
        CurrentObj = this;
    }

    internal void Stop()
    {
        moveSpeed = 0;
        float hangover = transform.position.x - LastObj.transform.position.x;
        
        float direction = hangover > 0 ? 1f : -1f;
        //SplitObjX(hangover, direction);

        float newXSize = LastObj.transform.localScale.x - Mathf.Abs(hangover);
    }

    /*
    private void SplitObjX(float hangover, float direction)
    {
        float newXSize = LastObj.transform.localScale.x - Mathf.Abs(hangover);
        float fallingBlockSize = transform.localScale.x - newXSize;
        float newXPosition = LastObj.transform.position.x + (hangover / 2);

        transform.localScale = new Vector2(newXSize, transform.localScale.y);
        transform.position = new Vector2(newXPosition, transform.position.y);

        float objEdge = transform.position.x + (newXSize / 2f * direction);
        float fallingBlockXPosition = objEdge + fallingBlockSize / 2f * direction;

        //SpawnDropCube(fallingBlockXPosition, fallingBlockSize);
    }

    private void SpawnDropCube(float fallingBlockXPosition, float fallingBlockSize)
    {
        //var dropObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject dropObj = new GameObject();
        Rect sampleRect = new Rect(1, 1, 1, 1);
        Sprite dropSprite = Sprite.Create(Texture2D.whiteTexture, sampleRect, new Vector2(0.5f, 0.5f));
        dropObj.AddComponent<SpriteRenderer>();
        dropObj.GetComponent<SpriteRenderer>().sprite = dropSprite;
        dropObj.GetComponent<SpriteRenderer>().color = Color.blue;
        dropObj.transform.localScale = new Vector3(fallingBlockSize, transform.localScale.y, 0f);
        dropObj.transform.position = new Vector3(fallingBlockXPosition, transform.position.y, 0f);
    }
    */

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * moveSpeed;
    }
}
