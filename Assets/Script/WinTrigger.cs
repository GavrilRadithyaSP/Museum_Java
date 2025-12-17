using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
