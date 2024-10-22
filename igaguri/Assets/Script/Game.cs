using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static SceneDate;

public class Game : MonoBehaviour
{

    public static Game Instance { get; private set; }
    public int score { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    //スタートメソッド
    public  void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("Game");
    }

    //エンドメソッド
    public void EndGame()
    {
        //獲得したスコアとリザルト画面へ遷移
        SceneData.score = Score_Script.instance.GetCurrentScore();

        SceneManager.LoadScene("Result");
    }
}
