using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed;
    public Rigidbody2D target;

    // bool isLive = true; // 몬스가 살아있을 때 true

    Rigidbody2D rigid;
    SpriteRenderer spriter;

    void Awake() {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate() {
        /*
        if(!isLive) {
            return;
        }
        */

        Vector2 dirVec = target.position - rigid.position;
        // 방향 = 위치 차이의 정규화
        // 위치 차이 = 타겟 위치 - 나의 위치
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        rigid.velocity = Vector2.zero;
        // 플레이어와 몬스터가 부딪혔을 때를 대비
    }

    void LateUpdate() {
        /*
        if(!isLive) {
            return;
        }
        */

        // 플레이어의 위치에 따라 모션 방향 바꾸기(오른쪽, 왼쪽)
        // spriter.flipX = target.position.x < rigid.position.x;
    }
}
