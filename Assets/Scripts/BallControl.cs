using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    GameObject pedal;
    bool isStartgame;
    void Start()
    {
        pedal = GameObject.Find("Pedal");
    }


    void Update()
    {
        if (!isStartgame)
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        if (Input.GetMouseButtonDown(0) && !isStartgame)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(Input.mousePosition.x * Time.deltaTime, 10f);
            isStartgame = true;
        }
    }
}
