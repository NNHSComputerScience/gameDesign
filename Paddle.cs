using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // The paddlePos variable stores the location of the paddle. 
        // This needs to be a 3D position vector because Unity stores all locations in three dimensions. 
        // The x value is 0.5 to set the paddle to the left of the game space, the y value is the current y value of the paddle, and the z value is 0.
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        // The mousePosInBlocks variable stores the position of the mouse in terms of world units. 
        // The x location of the mouse is found using Input.mousePosition.x and it is divided by the width of the screen to find the current mouse position. 
        // Multiplying by 16 world units will find the current block containing the mouse cursor.
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        // The Mathf.Clamp method sets the x position of the paddle and makes sure it is between 0.5 and 15.5. 
        // These are the points where the left or right side of the paddle would be hitting the edge of the game space.
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, -8.5f, 10.5f);
        // Finally, the last line sets the current position of the paddle to the paddlePos variable.
        this.transform.position = paddlePos;


        // Alternative where paddle position tracks with the mouse position on the screen
        //Vector3 paddlePos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y, 0);
        //paddlePos.x = Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, -8f, 8f); // Modified to be between -8 & 8
        //this.transform.position = paddlePos;
        
    }
}
