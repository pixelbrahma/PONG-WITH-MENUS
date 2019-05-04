using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    [SerializeField] private float speed;
    [SerializeField] private GameObject pause;
    private Rigidbody2D rb;
    private Vector2 velocity;
    private float width;
    private float height;
    public int player1Score = 0;
    public int player2Score = 0;
    private string scoreText = "";

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = Vector2.right * speed;
        velocity = new Vector2(velocity.x, 5);
        width = Camera.main.orthographicSize * Camera.main.aspect;
        height = Camera.main.orthographicSize;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pause.SetActive(true);
            }
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.y > height)
            velocity.y = -velocity.y;
        else if (transform.position.y < -height)
            velocity.y = -velocity.y;
        if(transform.position.x > width)
        {
            transform.position = new Vector3(0, 0, 0);
            rb.velocity = new Vector3(0, 0, 0);
            player1Score++;
        }
        else if(transform.position.x < -width)
        {

            transform.position = new Vector3(0, 0, 0);
            rb.velocity = new Vector3(0, 0, 0);
            player2Score++;
        }
        scoreText = player1Score.ToString() + "  :  " + player2Score.ToString();
        if (player1Score >= 10)
            scoreText = "PLAYER 1 WINS !!";
        else if (player2Score >= 10)
            scoreText = "PLAYER 2 WINS !!";
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Paddle")
            velocity.x = -velocity.x;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2, 20, 250, 20), scoreText);
    }
}
