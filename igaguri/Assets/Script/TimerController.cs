using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerController : MonoBehaviour
{
    public GameObject timeText;
    public string nextSceneName;
    public float transitionTime = 10f;

    private float elapsedTime = 0f;
    

    // Update is called once per frame
   // 2.5秒の遅延を管理するための変数
private float delayTime = 2.5f;
private float delayTimer = 0f;

void Update()
{
    // 最初の2.5秒間はタイマーを動かさない
    if (delayTimer < delayTime)
    {
        delayTimer += Time.deltaTime;
        return; // 2.5秒経つまでは以下の処理を行わない
    }

    // 2.5秒経過後に通常のタイマー処理を開始
    elapsedTime += Time.deltaTime;

    UpdatetimeText();

    if (elapsedTime >= transitionTime)
    {
        Game.Instance.EndGame();
    }
}

    private void UpdatetimeText()
    {
        this.timeText.GetComponent<TextMeshProUGUI>().text = "Time:" + elapsedTime.ToString("F2") + " Sec";
    }
}
