using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private SpawnPrefabs spawnPrefabs;

    [SerializeField] private Image image;
    [SerializeField] private TMP_Text startText;
    [SerializeField] private Button startButton;
    [SerializeField] private Button menuButton;
    [SerializeField] private Animation animationText;
    [SerializeField] private GameObject spawnScript;
    void Start()
    {

    }

    public void PlayGame()
    {
        startButton.gameObject.SetActive(false);
        startText.gameObject.SetActive(true);
        animationText.Play();
        Invoke("StartGame", 3.5f);
    }

    private void StartGame()
    {
        startText.gameObject.SetActive(false);
        spawnScript.SetActive(true);
        image.color = new Color32(52, 96, 91, 255);
        menuButton.gameObject.SetActive(true);
    }
    public void MenuGame()
    {
        spawnPrefabs.DeletePrefab();
        menuButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        spawnScript.SetActive(false);
        image.color = new Color32(35, 48, 34, 255);
    }
}
