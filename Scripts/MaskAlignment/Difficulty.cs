using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    public Camera mainCamera;
    public Dropdown difficultyDropdown;
    public Button zoomOutButton;
    public Text hintstext;

    private void Start()
    {
        zoomOutButton.gameObject.SetActive(true);
        difficultyDropdown.onValueChanged.AddListener(OnDifficultyChanged);
        hintstext.gameObject.SetActive(false);
    }

    private void OnDifficultyChanged(int index)
    {
        if (index == 0) // Easy mode
        {
            zoomOutButton.gameObject.SetActive(true);
            hintstext.gameObject.SetActive(false);
            mainCamera.orthographicSize = 18f;
        }
        else if (index == 1) // Hard mode
        {
            zoomOutButton.gameObject.SetActive(false);
            mainCamera.orthographicSize = 2f;
            hintstext.gameObject.SetActive(true);
        }
    }
}
