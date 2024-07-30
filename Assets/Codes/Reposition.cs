using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour {

    Collider2D coll;

    void Awake() {
        coll = GetComponent<Collider2D>();
    }
    void OnTriggerEnter2D(Collider2D collision) {
        /*
        if (!collision.CompareTag("Area"))
            return;
        */

        Vector3 playerPos = GameManager.instance.player.transform.position;
        Vector3 myPos = transform.position;
        float diffX = Mathf.Abs(playerPos.x - myPos.x);
        float diffY = Mathf.Abs(playerPos.y - myPos.y);

        Vector3 playerDir = GameManager.instance.player.inputVec;
        float dirX = playerDir.x < 0 ? -1 : 1;
        float dirY = playerDir.y < 0 ? -1 : 1;

        switch(transform.tag) {
            /*
            case "Ground":
                if(diffX > diffY) {
                    transform.Translate(Vector3.right * dirX * 40);
                }
                else if(diffX < diffY) {
                    transform.Translate(Vector3.up * dirX * 40);
                }
                break;
            */
            case "Enemy":
                if(coll.enabled) {
                    transform.Translate(playerDir * 20 + new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0f));
                    //플레이어의 이동 방향에 따라 맞은 편에서 등장하도록 이동
                }
                break;
        }
    }
}
