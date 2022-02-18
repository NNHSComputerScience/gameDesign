using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;
    Vector3 paddleToBallVector;
    bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        // The paddleToBallVector variable is the distance between the ball and the paddle before the ball starts moving. 
        // In the Update method, this is used to make sure the ball is always in that same position relative to the paddle if that game has not started.
        paddleToBallVector = this.transform.position - paddle.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;

            // The Input.GetMouseButtonDown call should make sense. The "0" represents the left mouse button. You can use "1" for the right button or "2" for the middle button. 
            // When the button is pressed down the hasStarted boolean is set to true so the code does not run again. The velocity vector of the ball is also set so the ball will start moving away from the paddle.

            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }

        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
            this.GetComponent<AudioSource>().Play();
    }

}