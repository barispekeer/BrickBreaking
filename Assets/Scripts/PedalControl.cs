using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalControl : MonoBehaviour
{
    GameObject ball;
    public AudioClip pedalHit;
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(Mathf.Clamp(mousePos.x,-3f,3f),transform.position.y, transform.position.z);
        //transform.position = new Vector3(Mathf.Clamp(ball.transform.position.x, -3.25f, 3.25f), transform.position.y, transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name.Equals("Ball"))
        {
            AudioSource.PlayClipAtPoint(pedalHit, transform.position);
        }
    }
}
