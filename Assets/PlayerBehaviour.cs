using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float moveHorizontal, moveVertical;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"), moveVertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(moveHorizontal, moveVertical).normalized * 0.01f);
    }
 
}


