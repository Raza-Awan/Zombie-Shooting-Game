using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Image Filler;
    public TMP_Text text;
    public int Duration;
    public UiManager uiManager;
    public PlayerControllerScript playerControllerScript;
    public GameObject gameOverPanel;
    public GameObject youWinPanel;
    public GameObject playerControlsUI;
    public GameObject TimerUI;

    int remainingDuration;
    [HideInInspector] public bool Pause;

    void Start()
    {
        //Begin(Duration);

        gameOverPanel.SetActive(false);
        youWinPanel.SetActive(false);
        Pause = true;
    }

    private void Update()
    {
        if (uiManager.buttonPressed == true)
        {
            Pause = !Pause;
            if (!Pause)
            {
                Begin(Duration);
            }
        }
    }

    private void Begin(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            text.text = $"{remainingDuration / 60:00}:{remainingDuration % 60:00}";
            Filler.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        OnEnd();
    }

    void OnEnd()
    {
        playerControllerScript.enabled = false;
        gameOverPanel.SetActive(true);
        playerControlsUI.SetActive(false);
        TimerUI.SetActive(false);
    }
}
