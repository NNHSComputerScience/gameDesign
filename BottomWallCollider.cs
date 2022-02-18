using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallCollider : MonoBehaviour
{
    public LevelManager levelManager;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        levelManager.loadLevel("Lose"); 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
