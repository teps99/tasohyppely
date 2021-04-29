using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRigid;
    public BoxCollider2D playerHitbox;
    private float moveSpeed = 5f;
    private float horizontalMovement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>();
        playerHitbox = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        float flipX = Input.GetAxisRaw("Horizontal");

        if (flipX != 0)
        {
            FlipPlayer(flipX);
        }
    }

    private void FlipPlayer(float flipX)
    {
        transform.localScale = new Vector2(flipX, transform.localScale.y);
    }


    private void FixedUpdate()
    {
        playerRigid.velocity = new Vector2(horizontalMovement * moveSpeed, playerRigid.velocity.y);

    }
}
