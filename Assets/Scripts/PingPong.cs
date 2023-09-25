using Unity.VisualScripting;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    private Transform _transform;

    [SerializeField] private Vector3 targetPos;
    private Vector3 pointA;
    private Vector3 pointB;

    public float speed = 2f;

    public void Start()
    {
        _transform = GetComponent<Transform>();

        pointA = _transform.position;
        pointB = pointA + new Vector3(3, 3, 3);

        targetPos = pointB;
    }

    public void Update()
    {
        Vector3 currentPos = _transform.position;
        float distance = Vector3.Distance(currentPos, targetPos);

        Vector3 direction = (targetPos - _transform.position).normalized;
        _transform.position += direction * speed * Time.deltaTime;

        if (distance < 0.1f)
        {
            if (targetPos == pointA)
            {
                targetPos = pointB;
            }
            else
            {
                targetPos = pointA;
            }
        }
    }
    //private Transform _transform;

    //[SerializeField] private float speed = 0f;

    //[SerializeField] private float distans;
    //[SerializeField] private float startTime = 0f;

    //[SerializeField] private Vector3 pointA;
    //[SerializeField] private Vector3 pointB;


    //private void Start()
    //{
    //    _transform = GetComponent<Transform>();
    //    pointA = _transform.position;
    //    pointB = pointA + new Vector3(2, 2, 2);
    //    distans = Vector3.Distance(pointA, pointB);
    //    startTime = Time.time;
    //}

    //void Update()
    //{

    //    float distanceCovered = (Time.time - startTime) * speed;//пройденное расстояние
    //    float fractionOfJourney = distanceCovered / distans;//часть пути
    //    print(fractionOfJourney);
    //    _transform.position = Vector3.Lerp(pointA, pointB, fractionOfJourney);
    //    if (fractionOfJourney >= 1.0f)
    //    {
    //        Vector3 temp = pointA;
    //        pointA = pointB;
    //        pointB = temp;

    //        startTime = Time.time;
    //    }
    //}
}
