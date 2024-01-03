using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject UI;
    [SerializeField] private Button StartButton;
    [SerializeField] private Button QuitButton;

    public bool isGameRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(HideUI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideUI()
    {
        UI.SetActive(false);
        isGameRunning = true;
    }
}
