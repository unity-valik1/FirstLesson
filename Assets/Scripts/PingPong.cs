using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector3 direction = new Vector3(1.0f, 0.0f, 0.0f);

    public float speed = 0f;
    //public float distans = 3;
    private float minX = -3;
    private float maxX = 3;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //float currentPosX = transform.position.x;

        //float time = currentPosX + speed * Time.deltaTime;

        //float newPos = Mathf.PingPong(time, distans);

        //transform.position = new Vector3(newPos, transform.position.y, transform.position.z);
        transform.Translate(direction * speed * Time.deltaTime);


        if (transform.position.x <= minX)
        {
            direction = new Vector3(1.0f, 0.0f, 0.0f);
        }
        if (transform.position.x >= maxX)
        {
            direction = new Vector3(-1.0f, 0.0f, 0.0f);
        }
    }
}
