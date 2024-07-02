using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //GameControllerスクリプトをインスタンス化
    
    //壁にぶつかったとき
    private void OnCollisionEnter(Collision collision)
    {
        if(GameController.instance == null)
        {
            GameController.instance = FindObjectOfType<GameController>();
        }

        if(GameController.instance != null)
        {
            GameController.instance.EndGame();
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("インスタンス化できていませんでした。");
        }
        //SceneManager.LoadScene("Result");
       // Destroy(collision.gameObject);
    }
}
