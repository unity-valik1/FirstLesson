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
        //Vector3 currentRotation = transform.rotation.eulerAngles; //Получаем текущий угол вращения
        //float newRotationY = currentRotation.y + rotationSpeed * Time.deltaTime;//Изменяем угол вращения по оси Y
        //Vector3 newRotation = new Vector3(45, newRotationY, currentRotation.z);//Новый вектор для нового вращения
        //transform.rotation = Quaternion.Euler(newRotation);//Применяем новый угол вращения к объекту

        angle += rotationSpeed * Time.deltaTime;
        _transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
    }
}
