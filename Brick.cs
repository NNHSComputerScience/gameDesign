using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int maxHits;
    int timesHit;
    public static int brickCount = 0;
    public LevelManager levelManager;


    void Start()
    {
        timesHit = 0;
        brickCount++;
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D ball)
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            brickCount--;
            levelManager.BrickDestroyed();
            Destroy(gameObject);
            
        }
    }

}
