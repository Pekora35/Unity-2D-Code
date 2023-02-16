using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAICode : MonoBehaviour
{

    public Transform GroundDetector;

    private float MoveSpeed = 7;
    private bool MovingLeft = true;

     

    void Update()
    {

        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);

        RaycastHit2D GroundInfo = Physics2D.Raycast(GroundDetector.position, Vector2.down, 1);

        if (GroundInfo.collider == false)
        {
            if (MovingLeft == true )
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                MovingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                MovingLeft = true;
            }
            
        }

    }
}
