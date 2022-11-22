using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickControl : MonoBehaviour
{
    public AudioClip brickHit;
    public AudioClip brickBroke;
    public static int maxBrick;
    public Sprite[] bricks;
    int maxImpact;
    int impact;
    ScoreControl sc;
    void Start()
    {
        maxImpact = bricks.Length + 1;
        maxBrick++;
        sc = GameObject.Find("MusicAndScore").GetComponent<ScoreControl>();
    }


    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name.Equals("Ball"))
        {
            impact++;
            sc.AddScore();
            if (impact >= maxImpact)
            {
                maxBrick--;
                if (maxBrick <= 0)
                {
                    GameObject.Find("Admin").GetComponent<GameControl>().NextScene();
                }
                AudioSource.PlayClipAtPoint(brickBroke, transform.position);
                Destroy(gameObject);
            }
            else
            {
                AudioSource.PlayClipAtPoint(brickHit, transform.position);
                GetComponent<SpriteRenderer>().sprite = bricks[impact - 1];
            }
        }
    }
}
