using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public GameObject door;
    public GameObject quizPanel;
    public TimerManager timer;

    public void JawabanBenar()
    {
        quizPanel.SetActive(false);
        door.SetActive(false); // buka pintu
        Time.timeScale = 1f;
    }

    public void JawabanSalah()
    {
        quizPanel.SetActive(false);
        Time.timeScale = 1f;
        timer.SpeedUpTime();
    }
}
