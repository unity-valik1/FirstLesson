using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Transform _transform;

    private float angle;
    public float rotationSpeed = 30.0f;

    private void Start()
    {
        _transform= GetComponent<Transform>();
    }

    void Update()
    {
        //Vector3 currentRotation = transform.rotation.eulerAngles; //�������� ������� ���� ��������
        //float newRotationY = currentRotation.y + rotationSpeed * Time.deltaTime;//�������� ���� �������� �� ��� Y
        //Vector3 newRotation = new Vector3(45, newRotationY, currentRotation.z);//����� ������ ��� ������ ��������
        //transform.rotation = Quaternion.Euler(newRotation);//��������� ����� ���� �������� � �������

        angle += rotationSpeed * Time.deltaTime;
        _transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
    }
}
