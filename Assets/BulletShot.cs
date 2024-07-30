using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Mouse Clicked.");

            GameObject bulletInstance = Instantiate(bullet, this.transform.position, Quaternion.identity);
            Destroy(bulletInstance, 2f);
        }
    }
}
