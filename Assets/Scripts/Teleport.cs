using UnityEngine;

public class Teleport : MonoBehaviour
{
    private Transform _transform; 

    public float teleportSpeed = 0.1f;
    private float time = 0f;
    private float timeN = 1.0f;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
    void Update()
    {
        time += teleportSpeed * Time.deltaTime;
        if (time >= timeN)
        {
            _transform.position = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f));
            time = 0;
        }
    }
}
