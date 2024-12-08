using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 3f;
    private Rigidbody2D playerRB2D;
    private Animator playerAnimator;
    private Vector2 playerPosition;

    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        playerPosition = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (playerPosition.sqrMagnitude > 0.1)
        {
            Move();
            playerAnimator.SetFloat("AxisX", playerPosition.x);
            playerAnimator.SetFloat("AxisY", playerPosition.y);
            playerAnimator.SetInteger("Movimento", 1);
        }
        else
        {
            playerAnimator.SetInteger("Movimento", 0);
        }
    }
    public void Move()
    {
        playerRB2D.MovePosition(playerRB2D.position + playerPosition * playerSpeed * Time.fixedDeltaTime);
    }
}
    

