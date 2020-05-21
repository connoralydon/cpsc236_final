using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBullet : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;

    private Text scoreText;
    private Text killText;
    private int tmpScore;
    private int tmpKill;
    private int healthCount = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        killText = GameObject.Find("Kills").GetComponent<Text>();
    }

    // Update is called once per frame

    void Update()
    {
        if (Camera.main.WorldToViewportPoint(transform.position).x > 1)
            Destroy(this.gameObject);

        tmpScore = scoreText.GetComponent<ScoreController>().score;
        tmpKill = killText.GetComponent<StatController>().kills;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            GameObject.Destroy(this.gameObject);
        }


        if (collision.gameObject.tag == "Enemy" )
        {
            GameObject.Destroy(this.gameObject);
            GameObject.Destroy(collision.gameObject);

            scoreText.GetComponent<ScoreController>().score = tmpScore + 20;
            scoreText.GetComponent<ScoreController>().UpdateScore();

            killText.GetComponent<StatController>().kills += tmpKill;// + 1;
            killText.GetComponent<StatController>().UpdateStats();
        }
        if (collision.gameObject.layer == 13)
        {

            if(healthCount > 0)
            {
                healthCount = healthCount -1;
                GameObject.Destroy(this.gameObject);
                Debug.Log(healthCount);
            }
            else if(healthCount <= 0)
            {
                GameObject.Destroy(this.gameObject);
                GameObject.Destroy(collision.gameObject);
                Debug.Log(healthCount);

                scoreText.GetComponent<ScoreController>().score = tmpScore + 100;
                scoreText.GetComponent<ScoreController>().UpdateScore();

                killText.GetComponent<StatController>().kills = tmpKill + 1;
                killText.GetComponent<StatController>().UpdateStats();
            }
            
        }
    }
}