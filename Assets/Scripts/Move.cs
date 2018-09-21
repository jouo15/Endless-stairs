using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform t;

    // const float LIMIT_POS_X = 5.9f;
    // const float LIMIT_POS_Y = 4f;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        t = GetComponent<Transform>();

        float x;
        float y;

        x = transform.position.x;
        y = transform.position.y;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        t.Translate(Vector2.right * h * 3f * Time.deltaTime);
        t.Translate(Vector2.up * v * 3f * Time.deltaTime);

        transform.Translate(new Vector2(h, v) * 3f * Time.deltaTime);


        Vector3 pos = transform.position;

        if (Mathf.Abs(pos.x) > GameManager.LIMIT_POS_X)
        {
            pos.x = Mathf.Sign(pos.x) * GameManager.LIMIT_POS_X;
        }
        if (Mathf.Abs(pos.y) > GameManager.LIMIT_POS_Y)
        {
            pos.y = Mathf.Sign(pos.y) * GameManager.LIMIT_POS_Y;
        }

        transform.position = pos;


        /*
        Vector3 position = transform.position;
        if (position.y > GameManager.LIMIT_POS_Y)
        {
            position = new Vector3(position.x, GameManager.LIMIT_POS_Y, 0f);
        }
        if (position.y < GameManager.LIMIT_POS_Y)
        {
            position = new Vector3(position.x, -GameManager.LIMIT_POS_Y, 0f);
        }
        if (position.x > GameManager.LIMIT_POS_X)
        {
            position = new Vector3(GameManager.LIMIT_POS_X, position.y, 0f);
        }
        if (position.x < GameManager.LIMIT_POS_X)
        {
            position = new Vector3(-GameManager.LIMIT_POS_X, position.y, 0f);
        }

        transform.position = position;
    }
    */
    }
}

// Mathf.Abs(값) : 넘겨준 값의 절대값을 구해줌
// Mathf.Sign() : 양수/0을 넣어주면 1을 리턴, 음수를 넣어주면 -1을 리턴

// 두번째 경계 처리 코드
/*
 Vector3 pos = transform.position;

 if (Mathf.Abs(pos.x) > GameManager.LIMIT_POS_X)
 {
     pos.x = Mathf.Sign(pos.x) * GameManager.LIMIT_POS_X;    
 }
 if (Mathf.Abs(pos.y) > GameManager.LIMIT_POS_Y)
  {
     pos.y = Mathf.Sign(pos.y) * GameManager.LIMIT_POS_Y;
 }

transform.position = pos;
}
    }

    */