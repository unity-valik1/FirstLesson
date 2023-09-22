using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 30.0f;

    void Update()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles; //Получаем текущий угол вращения

        float newRotationY = currentRotation.y + rotationSpeed * Time.deltaTime;//Изменяем угол вращения по оси Y

        
        Vector3 newRotation = new Vector3(45, newRotationY, currentRotation.z);//Новый вектор для нового вращения

        
        transform.rotation = Quaternion.Euler(newRotation);//Применяем новый угол вращения к объекту
    }
}
