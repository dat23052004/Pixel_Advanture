using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public Transform right;
    public Transform left;

    public bool isNonLoopAnaimation = false;
    public PlayerHPBar playerHPBar;

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

    GamepadInput gamepadInput;

    private void Awake()
    {
        gamepadInput = FindObjectOfType<GamepadInput>();
    }
    private void Start()
    {
        healthPoint = PlayerPrefs.GetInt("PlayerHP", 100);
        playerHPBar.updatePlayerHPBar(healthPoint);
    }

    void Update()
    {
        keybodrdController();
        //touchController();
        //gamepadController();
    }

    void gamepadController()
    {
        if (gamepadInput.LeftAnalogVector2.x <0)
        {
            playerMoveLeft();
        }
        else if (gamepadInput.LeftAnalogVector2.x >0)
        {
            playerMoveRight();
        }
        else
        {
            playerStopMovement();
        }

        if (gamepadInput.onButtonDown["Jump"] == true)
        {
            playerJump();
        }
        if (gamepadInput.onButtonHold["Run"])
        {
            playerRunOn();
        }
        if (gamepadInput.onButtonUp["Run"] == true)
        {
            playerRunOff();
        }
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
        if(Input.GetKeyDown("r"))
        {
            PlayerAttack();
        }
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
        
    }


    void playerMove(Vector2 moveVector)
    {
        Vector2 newMoveVector = new Vector2(moveVector.x*moveSpeed,rb.velocity.y);
        rb.velocity = newMoveVector;
        if(onGround == true)
        {
            if(moveSpeed == walkSpeed)
            {
                PlayingAnimation("Player Walk");
            }
            if(moveSpeed  == runSpeed)
            {
                PlayingAnimation("Player Run");
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
            PlayingAnimation("Player Idle");
        }
        
    }
    IEnumerator animotionJump()
    {
        yield return new WaitForSeconds(0.1f);
        PlayingAnimation("Player Jump");
    }

    void PlayingAnimation(string animation)
    {
        if(currentAnim != animation && isNonLoopAnaimation == false)
        {
            currentAnim = animation;
            playerAnimator.Play(currentAnim);
        }
    }

    void PlayingNonLoopAnimation(string animation)
    {
        if (currentAnim != animation)
        {
            currentAnim = animation;
            playerAnimator.Play(currentAnim);
        }
    }

    IEnumerator PrepareNonLoopAnaimation( string animationName)
    {
        isNonLoopAnaimation = true;
        PlayingNonLoopAnimation(animationName);
        yield return new WaitForEndOfFrame();
        var currentAnimationInfo = playerAnimator.GetCurrentAnimatorStateInfo(0);
        if(currentAnimationInfo.IsName(animationName) == true)
        {
            var animationDutarion = currentAnimationInfo.length;
            yield return new WaitForSeconds(animationDutarion);
            isNonLoopAnaimation = false;
        }
        else
        {
            yield return null;
            isNonLoopAnaimation = false;
        }   
    }

    void PlayerAttack()
    {
        StartCoroutine(PrepareNonLoopAnaimation("Player Attack"));
        CreateBullet();
    }

    void CreateBullet()
    {
        Vector3 bulletPosition = new Vector3();
        Vector2 bulletDirection = new Vector2();
        float bulletSpeed = 3f;
        if(playerSpriteRenderer.flipX == true)
        {
            bulletPosition = right.position;
            bulletDirection = new Vector2(1,0);
        }
        else
        {
            bulletPosition = left.position;
            bulletDirection = new Vector2(-1, 0);

        }

        var newBullet = Instantiate(bullet, bulletPosition,Quaternion.identity,null);
        var newBulletRigitbody = newBullet.GetComponent<Rigidbody2D>();
        newBulletRigitbody.velocity = bulletDirection * bulletSpeed;
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
            playerHPBar.updatePlayerHPBar(healthPoint); // update hp to HPBar
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
