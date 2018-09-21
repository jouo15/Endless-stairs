using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 씬 관리 사용
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour {

    public Text _ResultText;
    

        void Start () {

        GetJewelNum();

	     }

    // 재시작 버튼을 클릭했을때 실행됨
    public void OnRestartButtonClick()
    {
        Debug.Log("OnRestartButtonClick");
        SceneManager.LoadScene("Game");
 
    }

    public void GetJewelNum()
    {
        _ResultText.text = GameManager.JewelCount;
       
        
    }
	

}
