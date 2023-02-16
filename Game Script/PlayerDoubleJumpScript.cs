using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoubleJumpScript : MonoBehaviour
{
    Rigidbody2D PlayerRigid;

    private float JumpPower = 20;
    int ExtraJump;

    public GameObject GroundDetector;
    public LayerMask PlatFormLayer;
    private float GroundRadius = 0.5f;
    bool GroundChecker;

    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerDoubleJump();
    }

    void PlayerDoubleJump()
    {
        GroundChecker = Physics2D.OverlapCircle(GroundDetector.transform.position, GroundRadius, PlatFormLayer);

        if (GroundChecker == true)
        {
            ExtraJump = 1;
        }

        if(Input.GetKeyDown(KeyCode.Space) && ExtraJump > 0)
        {
            PlayerRigid.velocity = Vector2.up * JumpPower;
            ExtraJump--;
        }
        if(Input.GetKeyDown(KeyCode.Space) && ExtraJump == 0 && GroundChecker == true)
        {
            PlayerRigid.velocity = Vector2.up * JumpPower;
        }
        
    }
}
