using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class Flag : MonoBehaviour
{

    private bool isNearFlag = false;

    void StartMiniGame()
    {
        // 미니게임 실행 로직 추가
        SceneManager.LoadScene("TheStackScene");

    }


    // Flag와 충돌했을 때
    void OnTriggerEnter2D(Collider2D Flag)
    {
        isNearFlag = true;
        Debug.Log("미니게임 시작");
        StartMiniGame();

    }

    //void Update()
    //{
    //    if (isNearFlag && Input.GetKeyDown(KeyCode.F))
    //    {
    //        isNearFlag = true;
    //        StartMiniGame();
    //    }
    //}
}



