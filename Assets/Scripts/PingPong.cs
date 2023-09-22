using UnityEngine;

public class PingPong : MonoBehaviour
{
    private Transform _transform;

    public Vector3 direction = new Vector3(1.0f, 0.0f, 0.0f);

    public float speed = 0f;
    private float minX = -3;
    private float maxX = 3;
    //public float distans = 3;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        //float currentPosX = transform.position.x;
        //float time = currentPosX + speed * Time.deltaTime;
        //float newPos = Mathf.PingPong(time, distans);
        //transform.position = new Vector3(newPos, transform.position.y, transform.position.z);

        _transform.Translate(direction * speed * Time.deltaTime);

        if (_transform.position.x <= minX)
        {
            direction = new Vector3(1.0f, 0.0f, 0.0f);
        }
        if (_transform.position.x >= maxX)
        {
            direction = new Vector3(-1.0f, 0.0f, 0.0f);
        }
    }
}
