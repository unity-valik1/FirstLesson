using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private SpawnPrefabs spawnPrefabs;

    public Image image;
    public TMP_Text startText;
    public Button startButton;
    public Button menuButton;
    public Animation animationText;
    public GameObject spawnScript;
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
