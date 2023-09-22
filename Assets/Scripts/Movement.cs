using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 direction = new Vector3(1.0f, 0.0f, 0.0f);
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction * speed;
        //или
        //transform.Translate(direction* speed);
        //
        //transform.Translate(direction * speed * Time.deltaTime); - самый лучший способ!!!
    }
}
