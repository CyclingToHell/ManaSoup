using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   

    //Movement
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    //DoubleJump
     private bool doubleJump;

    //CoyoteTime
    private bool isJumping;

    private float coyoteTime = 0.2f;
    private float coyoteTimeCounter;

    private float jumpBufferTime = 0.2f;
    private float jumpBufferCounter;

    //WallSlide
    private bool isWallSliding;
    private float wallSlidingSpeed = 2f;

    //WallJump
    private bool isWallJumping;
    private float wallJumpingDirection;
    private float wallJumpingTime = 0.2f;
    private float wallJumpingCounter;
    private float wallJumpingDuration = 0.4f;
    private Vector2 wallJumpingPower = new Vector2(8f, 16f);

    //Dash
    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;


    private float vertical;
    // Start is called before the first frame updateprivate float vertical;
    private float ladderSpeed = 8f;
    private bool isLadder;
    private bool isClimbing;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Animator animator;
    [SerializeField] private TrailRenderer tr;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask wallLayer;

    //Audio
    [SerializeField] private AudioSource soundJump;
    [SerializeField] private AudioSource soundWalk;
    [SerializeField] private AudioSource soundDash;
    [SerializeField] private AudioSource soundWall;


    void Update()
    {
        //CoyoteTime
        if (IsGrounded())
        {
            coyoteTimeCounter = coyoteTime;
        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }

        //Dash
        if (isDashing)
        {
            return;
        }

        //DoubleJump
        if (IsGrounded() && !Input.GetButton("Jump"))
        {
            doubleJump = false;
        }
        

        if (Input.GetButtonDown("Jump"))
        {   
            //CoyoteTime
            jumpBufferCounter = jumpBufferTime;

            //DoubleJump
            if (IsGrounded() || doubleJump)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                
                doubleJump = !doubleJump;
            }

        }
        //CoyoteTime
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }
        
        //CoyoteTime
        if (coyoteTimeCounter > 0f && jumpBufferCounter > 0f && !isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);

            jumpBufferCounter = 0f;

            StartCoroutine(JumpCooldown());
        }

        //Movement
        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if(horizontal != 0)
        {
            soundWalk.Play();
        }
        

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            soundJump.Play();
            StartCoroutine(AnimJump());
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);

            //CoyoteTime
            coyoteTimeCounter = 0f;
        }

        WallSlide();
        WallJump();

        if (!isWallJumping)
        {
            Flip();
        }

        //DashAnim
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(AnimDash());
            StartCoroutine(Dash());
            
            soundDash.Play();
            
        }
        Flip();


        vertical = Input.GetAxisRaw("Vertical");

        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
        if (!isWallJumping)
        {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        }

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * ladderSpeed);
        }
        else
        {
            rb.gravityScale = 4f;
        }
    }

    private bool IsGrounded()
    {
        
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private bool IsWalled()
    {   
        
        return Physics2D.OverlapCircle(wallCheck.position, 0.2f, wallLayer);
        
    }

    private void WallSlide()
    {
        if (IsWalled() && !IsGrounded() && horizontal != 0f)
        {   
            
            isWallSliding = true;
            animator.SetBool("IsSliding", true);
            
            
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -wallSlidingSpeed, float.MaxValue));
        }
        else
        {
            soundWall.Play();
            isWallSliding = false;
            animator.SetBool("IsSliding", false);
        }
    }

    private void WallJump()
    {
        if (isWallSliding)
        {
            
            isWallJumping = false;
            wallJumpingDirection = -transform.localScale.x;
            wallJumpingCounter = wallJumpingTime;

            CancelInvoke(nameof(StopWallJumping));
        }
        else
        {
            wallJumpingCounter -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump") && wallJumpingCounter > 0f)
        {   

            doubleJump = false;
            
            soundJump.Play();
            rb.velocity = new Vector2(wallJumpingDirection * wallJumpingPower.x,wallJumpingPower.y );
            wallJumpingCounter = 0f;

            if (transform.localScale.x != wallJumpingDirection)
            {

                isFacingRight = !isFacingRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
                
            }

            Invoke(nameof(StopWallJumping), wallJumpingDuration);
        }
    }

    private void StopWallJumping()
    {
        isWallJumping = false;
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
    private IEnumerator JumpCooldown()
    {
        isJumping = true;
        yield return new WaitForSeconds(0.4f);
        isJumping = false;
    }

    private IEnumerator AnimJump()
    {
        animator.SetBool("IsJumping", true);
        yield return new WaitForSeconds(0.6f);
        animator.SetBool("IsJumping", false);
    }

    private IEnumerator AnimWalk()
    {
        animator.SetBool("IsWalking", true);
        yield return new WaitForSeconds(0.6f);
        animator.SetBool("IsWalkling", false);
    }

    private IEnumerator AnimWallSlide()
    {
        animator.SetBool("IsSliding", true);
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("IsSliding", false);
    }

    private IEnumerator AnimDash()
    {
        animator.SetBool("IsDashing", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("IsDashing", false);
    }

    private IEnumerator AnimWallJump()
    {
        animator.SetBool("IsWallJumping", true);
        yield return new WaitForSeconds(0.6f);
        animator.SetBool("IsWallJumping", false);
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
            doubleJump = true;
        }
    }
    
}
