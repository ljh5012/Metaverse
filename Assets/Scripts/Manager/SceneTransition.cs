using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // ���÷� 'MiniGameScene' ������ ��ȯ
    public void LoadTheStackScene()
    {
        SceneManager.LoadScene("TheStackScene");
    }

    // Update() �Լ����� Ư�� ���ǿ� ���� �� ��ȯ
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F)) // FŰ�� ������ �� �� ��ȯ
        void OnTriggerEnter2D(Collider2D other)
        {
            LoadTheStackScene();
        }
    }
}
