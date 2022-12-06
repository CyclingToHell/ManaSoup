using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    private float vertical;
    // Start is called before the first frame updateprivate float vertical;
    private float speed = 8f;
    private bool isLadder;
    private bool isClimbing;

    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");

        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 4f;
        }
    }

    private void OnTriggerEnter2D(Collider2D ladder)
    {
        if (ladder.CompareTag("Leiter"))
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D ladder)
    {
        if (ladder.CompareTag("Leiter"))
        {
            isLadder = false;
            isClimbing = false;
        }
    }
}
