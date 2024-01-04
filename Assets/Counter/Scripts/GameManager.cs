using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameRunning = false;
    public int count;

    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject GameOverUI;
    [SerializeField] private Button StartButton;
    [SerializeField] private Button PlayAgainButton;
    [SerializeField] private Button QuitButton;
    [SerializeField] private Button QuitButtonSecond;
    [SerializeField] private GameObject target;

    private float minSpawnRate = 1.0f;
    private float maxSpawnRate = 5.0f;

    // Start is called before the first frame update
    private void Start()
    {
        StartButton.onClick.AddListener(HideUI);
        PlayAgainButton.onClick.AddListener(RestartGame);
        QuitButton.onClick.AddListener(QuitGame);
        QuitButtonSecond.onClick.AddListener(QuitGame);

        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count < 0)
        {
            GameOver();
        }
    }

    public void HideUI()
    {
        isGameRunning = true;
        UI.SetActive(false);
        StartCoroutine(SpawnTarget());
    }
    public void IncreaseCount()
    {
        count++;
    }

    public void DecreaseCount() 
    { 
        count--;
    }
    private IEnumerator SpawnTarget()
    {
        while (isGameRunning)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnRate, maxSpawnRate));
            Instantiate(target);
        }
    }
    private void GameOver()
    {
        isGameRunning = false;
        GameOverUI.SetActive(true);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
