using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ResultController : MonoBehaviour
{
    //テキスト生成
    public GameObject scoreText;
    public GameObject resultText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "SCORE:" + SceneData.score;
        //GAMECLEAR or GAMEOVER
        if (SceneData.totalBlocks == 0)
        {
            this.resultText.GetComponent<TextMeshProUGUI>().text = "GAME CLEAR";
        }
        else
        {
            this.resultText.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
        }
    }
    //スタート画面への遷移
    public void OnReturnBottonPressed()
    {
        GameController.instance.ReturnStart();
    }
}
