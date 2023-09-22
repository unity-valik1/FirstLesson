using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 30.0f;

    void Update()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles; //�������� ������� ���� ��������

        float newRotationY = currentRotation.y + rotationSpeed * Time.deltaTime;//�������� ���� �������� �� ��� Y

        
        Vector3 newRotation = new Vector3(45, newRotationY, currentRotation.z);//����� ������ ��� ������ ��������

        
        transform.rotation = Quaternion.Euler(newRotation);//��������� ����� ���� �������� � �������
    }
}
