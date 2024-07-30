using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 inputVec; // 플레이어 관련 입력 벡터
    public float speed = 3;

    Rigidbody2D rigid;

    void Awake() {
        // 생명주기 함수
        rigid = GetComponent<Rigidbody2D>();
        // 오브젝트에서 컴포넌트 함수를 가져오는 함수
    }

    void OnMove(InputValue value) {
        inputVec = value.Get<Vector2>();
        // Get<T> : 프로필에서 설정한 컨트롤 타임 T 값을 가져오는 함수
    }

    void FixedUpdate() {
        Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime; // 벡터 값을 잠시 저장할 변수
        // normalized : 벡터 값의 크기가 1이 되도록 좌표가 수정된 값
        // fixedDeltaTime : 물리 프레임 하나가 소비한 시간

        rigid.MovePosition(rigid.position + nextVec);
    }
}
