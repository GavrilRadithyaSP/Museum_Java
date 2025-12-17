using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public float timeLeft = 60f;
    public float timeSpeed = 1f;
    public TMP_Text timerText;
    public GameObject losePanel;
    public GameObject quizPanel;

    void Update()
    {
        timeLeft -= Time.deltaTime * timeSpeed;
        timerText.text = Mathf.Ceil(timeLeft).ToString();

        if (timeLeft <= 0)
        {
            LoseGame();
        }
    }

    public void SpeedUpTime()
    {
        timeSpeed += 0.5f; // makin cepat setiap salah
    }

    void LoseGame()
    {
        losePanel.SetActive(true);
        quizPanel.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
