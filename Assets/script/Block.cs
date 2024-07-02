using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //スコア
    public int score = 10;
    private BlockGenerator blockGenerator;
    //何かとぶつかった時に呼ばれる
    private void Start()
    {
        blockGenerator = FindObjectOfType<BlockGenerator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスがありません。");
        }
        //ブロックがぶつかったに生成したカウントを減らしていく
        blockGenerator.BlockDestroyed();
        //ゲームオブジェクトを削除する
        Destroy(gameObject);
    }
}
