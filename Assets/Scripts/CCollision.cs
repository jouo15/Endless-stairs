using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCollision : MonoBehaviour {

    public GameManager _gameManager;
    public GameObject blueJewel;

    // OnTriggerEnter2D(충돌체의 Collider 컴포넌트 참조)
    // -> IsTrigger가 체크된 Collider 끼리 충돌하면
    // 호출해주는 유니티 이벤트 메소드 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("플레이어가 무언가 충돌함");


        // Collider2D는 부모로 Behaviour를 상속받고 있고
        // 때문에 gameObject  객체를 접근하여 파괴할 수 있다
        // 유니티는 gameObject를 파괴해야 해당 게임오브젝트와
        // 연결된 모든 컴포넌트들이 파괴된다.
        // * Destroy에 collision을 넘겨주면 충돌된 오브젝트는
        // Collider 컴포넌트만 파괴된다.


        // Destroy(collision.gameObject, 0.3f);
        if (collision.CompareTag("BlueJewel"))
        {
            Destroy(collision.gameObject);
        }


      

        _gameManager.JewelCountUp();
     
    }

   

}
