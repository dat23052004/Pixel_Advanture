using System;
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
    public float walkSpeed = 1;
    public float runSpeed = 1;
    public float jumpStrength = 1;

    public bool onGround = false;
    public SpriteRenderer playerSpriteRenderer;

    public Animator playerAnimator;

    public bool isPressedButtonRight = false;
    public bool isPressedButtonLeft = false;

    public int healthPoint = 1;

    public bool canTakeDamege = true;
    public Color colorShield;
    public Color colorNormal;
    private void Start()
    {
        healthPoint = PlayerPrefs.GetInt("PlayerHP", 100);
    }

    void Update()
    {
        keybodrdController();
        //touchController();
    }
    void touchController()
    {
        if (isPressedButtonRight == true)
        {
            playerMoveRight();
        }
        else if (isPressedButtonLeft == true)
        {
            playerMoveLeft();
        }
        else
        {
            playerStopMovement();
        }
    }
    void keybodrdController()
    {
        if (Input.GetKey("a"))
        {
           playerMoveLeft();
        }
        else if (Input.GetKey("d"))
        {
            playerMoveRight();
        }
        else
        {
            playerStopMovement();
        }

        if (Input.GetKeyDown("space") == true )
        {
            playerJump();
        }
        if (Input.GetKey("left shift") == true)
        {
            playerRunOn();
        }
        if (Input.GetKeyUp("left shift") == true)
        {
            playerRunOff();
        }
    }

    public void playerRunOn()
    {
        if(moveSpeed != runSpeed)
        {
            StartCoroutine(changePlayerSpeed(runSpeed));

        }
    }

    public void playerRunOff()
    {
        if(moveSpeed != walkSpeed)
        {
           StartCoroutine(changePlayerSpeed(walkSpeed));
        }
    }

    IEnumerator changePlayerSpeed(float newSpeed)
    {
        yield return new WaitUntil(()=> onGround == true);
        moveSpeed = newSpeed;
        Debug.Log("new speed is " + moveSpeed);
    }


    void playerMove(Vector2 moveVector)
    {
        Vector2 newMoveVector = new Vector2(moveVector.x*moveSpeed,rb.velocity.y);
        rb.velocity = newMoveVector;
        if(onGround == true)
        {
            if(moveSpeed == walkSpeed)
            {
                changeAnim("Player Walk");
            }
            if(moveSpeed  == runSpeed)
            {
                changeAnim("Player Run");
            }
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
            playerAnimator.Play(currentAnim);
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

    public void playerHealthPointUpdate(int addingValue)
    {
        if(canTakeDamege)
        {
            canTakeDamege = false;
            healthPoint += addingValue;
            PlayerPrefs.SetInt("PlayerHP", healthPoint);
            PlayerPrefs.Save();
            StartCoroutine(givePlayerShield());
        }
        
    }

    IEnumerator givePlayerShield()
    {
        playerSpriteRenderer.color = colorShield;
        yield return new WaitForSeconds(3);
        canTakeDamege = true;
        playerSpriteRenderer.color = colorNormal;
    }

  
}
