using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Transform _transform;

    [SerializeField] private Vector3 v3 = new Vector3(1f, 0f, 0f);

    [SerializeField] private float rotationSpeed = 30.0f;
    private void Start()
    {
        _transform= GetComponent<Transform>();
    }

    void Update()
    {
        _transform.Rotate(v3, rotationSpeed);
    }
}
