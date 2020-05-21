﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBullet : MonoBehaviour
{

    public static float speed = 17.5f;
    private Rigidbody2D rb;

    private Text scoreText;
    private Text killText;
    private int tmpScore;
    private int tmpKill;


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
        tmpKill = killText.GetComponent<StatKillController>().kills;
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

            killText.GetComponent<StatKillController>().kills += tmpKill;// + 1;
            killText.GetComponent<StatKillController>().UpdateStats();
        }
        if (collision.gameObject.layer == 13)
        {
            GameObject.Destroy(this.gameObject);
            GameObject.Destroy(collision.gameObject);

            scoreText.GetComponent<ScoreController>().score = tmpScore + 100;
            scoreText.GetComponent<ScoreController>().UpdateScore();

            killText.GetComponent<StatKillController>().kills = tmpKill + 1;
            killText.GetComponent<StatKillController>().UpdateStats();

            
        }
    }
}