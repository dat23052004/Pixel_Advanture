using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 vectorToRight = new Vector2(1, 0);
    Vector2 vectorToLeft = new Vector2(-1, 0);
    private string currentAnim = "";
    public float moveSpeed = 1;
    public float jumpStrength = 1;

    public bool onGround = false;
    public SpriteRenderer playerSpriteRenderer;

    public Animator playerAnimator;
    void Start()
    {

    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetKey("d"))
        {
            playerMoveRight();
        }
        else if (Input.GetKey("a"))
        {
            playerMoveLeft();
        }
        else
        {
            playerStopMovement();
        }
        if (Input.GetKeyDown("space") == true )
        {
            playerJump();
        }
    }

    void playerMove(Vector2 moveVector)
    {
        Vector2 newMoveVector = new Vector2(moveVector.x*moveSpeed,rb.velocity.y);
        rb.velocity = newMoveVector;
        if(onGround == true)
        {
            changeAnim("Player Walk");
        }
        
    }

    void playerRotation(bool boolValue)
    {
        playerSpriteRenderer.flipX = boolValue;
    }

    void animotionStop()
    {
        if(onGround == true)
        {
            changeAnim("Player Idle");
        }
        
    }
    IEnumerator animotionJump()
    {
        yield return new WaitForSeconds(0.1f);
        changeAnim("Player Jump");
    }

    void changeAnim(string animation)
    {
        if(currentAnim != animation)
        {
            currentAnim = animation;
            playerAnimator.Play(animation);
        }
    }

    public void playerMoveRight()
    {
        playerMove(vectorToRight);
        playerRotation(true);
    }
    public void playerMoveLeft()
    {
        playerMove(vectorToLeft);
        playerRotation(false);
    }

    public void playerStopMovement()
    {
        animotionStop();
    }

    public void playerJump()
    {
        if (onGround == true)
        {
            rb.AddForce(new Vector2(0, 1) * jumpStrength, ForceMode2D.Impulse);
            StartCoroutine(animotionJump());
        }
    }

    public void gameRestart()
    {
        string currentSceneName = gameObject.scene.name;
        SceneManager.LoadScene(currentSceneName);
    }
}
