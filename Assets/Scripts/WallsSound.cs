using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsSound : MonoBehaviour
{
    public AudioClip wallHit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name.Equals("Ball"))
        {
            AudioSource.PlayClipAtPoint(wallHit, transform.position);
        }
    }
}
