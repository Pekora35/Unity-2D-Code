using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpScript : MonoBehaviour
{
    Rigidbody2D PlayerRigid;


    bool PlayerAreJumping;
    float JumpTimeCounter;
    private float JumpPower = 15;


    public GameObject GroundDetector;
    public LayerMask PlatFormLayer;
    private float GroundRadius = 0.7f;
    bool GroundChecker;




    // Start is called before the first frame update
    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PLayerJump();
    }

    void PLayerJump()
    {
        GroundChecker = Physics2D.OverlapCircle(GroundDetector.transform.position, GroundRadius, PlatFormLayer);

        if(Input.GetKeyDown(KeyCode.Space) && GroundChecker == true)
        {
            PlayerAreJumping = true;
            JumpTimeCounter = 0.5f;
            PlayerRigid.velocity = Vector2.up * JumpPower;
        }

        if(JumpTimeCounter > 0)
        {
            if(Input.GetKey(KeyCode.Space) && PlayerAreJumping == true)
            {
                PlayerRigid.velocity = Vector2.up * JumpPower;
                JumpTimeCounter = JumpTimeCounter - Time.deltaTime;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                PlayerAreJumping = false;
            }
        }
    }
}
