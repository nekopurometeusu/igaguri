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
   // 2.5�b�̒x�����Ǘ����邽�߂̕ϐ�
private float delayTime = 2.5f;
private float delayTimer = 0f;

void Update()
{
    // �ŏ���2.5�b�Ԃ̓^�C�}�[�𓮂����Ȃ�
    if (delayTimer < delayTime)
    {
        delayTimer += Time.deltaTime;
        return; // 2.5�b�o�܂ł͈ȉ��̏������s��Ȃ�
    }

    // 2.5�b�o�ߌ�ɒʏ�̃^�C�}�[�������J�n
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
