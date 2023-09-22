using UnityEngine;

public class Scaler : MonoBehaviour
{
    private Transform _transform;

    private float scalerSpeed = 1.0f;
    [SerializeField] private float minX = 1;
    [SerializeField] private float maxX = 3;

    private bool scaler_flag = true;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        float currentScale = _transform.localScale.x + scalerSpeed * Time.deltaTime;

        _transform.localScale = new Vector3(currentScale, currentScale, currentScale);

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
