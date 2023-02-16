using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody2D PlayerRigid;

    public float MoveSpeed = 10;


    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
         
    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        PlayerRigid.velocity = new Vector2(Horizontal * MoveSpeed, PlayerRigid.velocity.y);

        if(Horizontal > 0.01f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }else if(Horizontal < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
