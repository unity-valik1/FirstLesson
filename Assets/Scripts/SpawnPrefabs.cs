using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
    public GameObject[] prefab;
    public GameObject instance;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(prefab == null)
            {
                Debug.LogError("Prefab is null!");
                return;
            }
            if(instance != null)
            {
                Destroy(instance);
            }
            var rotation = Quaternion.identity;
            var position = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f));
            
            instance = Instantiate(prefab[Random.Range(0, prefab.Length)], position, rotation);
        }
    }

    public void DeletePrefab()
    {
        Destroy(instance);
    }
}
