 using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {

        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

    private void flewOverTheScreen()
    {
        if (transform.position.y > 6 || transform.position.y < -6.30)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void Jump() {

        if (Input.touchCount > 0 && birdIsAlive)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                myRigidBody.linearVelocity = Vector2.up * flapStrength;
                SoundManager.soundManager.PlayJumpSound();
            }
            
        }

        flewOverTheScreen();
    }
}
