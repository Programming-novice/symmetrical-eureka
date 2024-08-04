using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {
 
    public void Test() {
        Debug.Log("버튼 함수 호출 테스트");
    }

    
    public void StartGame() {
        SceneManager.LoadScene("1_Play");
    }
    
}
