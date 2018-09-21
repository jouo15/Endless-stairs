using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 유니티 UI사용
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public static string JewelCount;

    public static float LIMIT_POS_X = 5.9f;
    public static float LIMIT_POS_Y = 4f;

    public GameObject _blueJewelPrefab; // 프리팹 참조 변수
    // * 프리팹 로드 : 프리팹 파일을 참조 변수로 드래그 앤 드랍
    public float _jewelCreatedelayTime;
    public float _timerTime;

    public Text _jewelCountText;
    public Text _TimerCountText;

    

	// Use this for initialization
	void Start () {

        // JewelCount = "0";

        // InvokeRepeating() 
        // - 특정 시간 간격으로 특정 메소드를 지속적으로 실행해주는 메소드

        InvokeRepeating("CreateRedJewel" , 1f, _jewelCreatedelayTime);
        InvokeRepeating("TimerCountDown", 1f, _timerTime);
   
        // CancelInvoke();
        // CancelInvoke("CreateRedJewel");
        // - 현재 메소드를 주기적으로 실행하는 InvokeRepeating을 취소함
        
    }

    void CreateRedJewel()
    {
        // 프리팹 (prefab)
        // - 씬뷰에 디자인한 게임 오브젝트에 복제 하기위해 만든 파일을 말한다. 

        // 프리팹을 게임 오브젝트로 생성
        // GameObject 생성된 게임 오브젝트 참조 변수
        // = Instantiate( 프리팹 참조, 생성 위치, 생성시 회전값);   


        float x = Random.Range(-LIMIT_POS_X, LIMIT_POS_X);
        float y = Random.Range(-LIMIT_POS_Y, LIMIT_POS_Y);
        // * Quaternion.identitiy : 월드의 회전

        Instantiate(_blueJewelPrefab, new Vector3(x, y, 0), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {     		
	}

    public void JewelCountUp()
    {
        // 보석 카운트를 표시하는 텍스트의 값을 추출
        string strCount = _jewelCountText.text;

        // 카운트 값을 증가함

        // 문자열을 정수로 변환

        // int value = int.Parse(문자열숫자);
        int count = int.Parse(strCount);
        count += 10;

        // 카운트 값을 보석 카운트에 적용함

        // 정수를 문자열로 변환
        // string text = 정수형변수. ToString();

        strCount = count.ToString();
       JewelCount =  _jewelCountText.text = strCount;

    }

    public void TimerCountDown()
    {
        string timerCount = _TimerCountText.text;
        int count = int.Parse(timerCount);
        count--;

        if (count <= 0)
        {
            // CancelInvoke("CreateRedJewel");
            // CancelInvoke("TimerCountDown");
            CancelInvoke();
            SceneManager.LoadScene("End");
        }

        timerCount = count.ToString();
        _TimerCountText.text = timerCount;


    }


}
