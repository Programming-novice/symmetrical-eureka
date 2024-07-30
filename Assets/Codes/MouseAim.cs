using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m_curPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        m_curPos.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;

        Vector2 direction = m_curPos - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);

        transform.eulerAngles = new Vector3(0, 0, angle);

    }
}
