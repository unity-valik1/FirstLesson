using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public float scalerSpeed = 1.0f;

    public float minX = 1;
    public float maxX = 3;

    private bool scaler_flag = true;


    void Update()
    {
        float currentScale = transform.localScale.x + scalerSpeed * Time.deltaTime;

        transform.localScale = new Vector3(currentScale, currentScale, currentScale);

        if (currentScale > maxX && scaler_flag == true)
        {
            scalerSpeed = -scalerSpeed;
            scaler_flag = false;
        }
        if (currentScale < minX && scaler_flag == false)
        {
            scalerSpeed = 1.0f;
            scaler_flag = true;
        }
    }
}
