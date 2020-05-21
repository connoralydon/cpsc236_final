using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController2 : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;

    public Animator animator;

    public GameObject bullet;

    private Text scoreText;
    private int tmpScore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        BoundMovement();

        Shoot();

        tmpScore = scoreText.GetComponent<ScoreController>().score;
    }


    void Shoot()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
            GameObject.Instantiate(bullet, transform.position, transform.rotation); //bring in object at players ship
            scoreText.GetComponent<ScoreController>().score = tmpScore - 1;
            scoreText.GetComponent<ScoreController>().UpdateScore();
        }
	}

    void Move()
	{
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        float moveX = x * speed;
        float moveY = y * speed;

        rb.velocity = new Vector2(moveX, moveY);
        
	}

    void BoundMovement()
    {
        float dist = (this.transform.position - Camera.main.transform.position).z;

        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
        float topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
        float bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;

        Vector3 playerSize = GetComponent<Renderer>().bounds.size;

        this.transform.position = new Vector3(
        Mathf.Clamp(this.transform.position.x, leftBorder + playerSize.x / 2, rightBorder - playerSize.x / 2),
        Mathf.Clamp(this.transform.position.y, topBorder + playerSize.y / 2, bottomBorder - playerSize.y / 2),
        this.transform.position.z
        );
    }
}



