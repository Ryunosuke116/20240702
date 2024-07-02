using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("Game");
    }
    // Start is called before the first frame update

    //ゲーム終了
    public void EndGame()
    {
        //獲得したスコアとリザルト画面へ遷移
        SceneData.score = ScoreScript.instance.GetCurrentScore();
        SceneManager.LoadScene("Result");
    }

    public void ReturnStart()
    {
        SceneManager.LoadScene("Start");
    }

}
