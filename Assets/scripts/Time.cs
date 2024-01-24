using UnityEngine;
using TMPro;

public class Time : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float totalTime = 60f; // Gesamte Zeit in Sekunden

    private float currentTime;

    void Start()
    {
        currentTime = totalTime;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            // Timer abgelaufen
            Debug.Log("Zeit abgelaufen!");
        }
    }

    void UpdateTimerDisplay()
    {
        // Formatierung der verbleibenden Zeit als Minuten und Sekunden
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        // Aktualisierung des TextMeshPro-Textes
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}