using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // 예시로 'MiniGameScene' 씬으로 전환
    public void LoadTheStackScene()
    {
        SceneManager.LoadScene("TheStackScene");
    }

    // Update() 함수에서 특정 조건에 따라 씬 전환
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F)) // F키를 눌렀을 때 씬 전환
        void OnTriggerEnter2D(Collider2D other)
        {
            LoadTheStackScene();
        }
    }
}
