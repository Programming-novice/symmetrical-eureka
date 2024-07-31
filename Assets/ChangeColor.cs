using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    // Start is called before the first frame update
    SpriteRenderer sprite;
    void Start() {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        sprite.color = Color.red;
    }

    // Update is called once per frame
    void Update() {
        
    }
}
