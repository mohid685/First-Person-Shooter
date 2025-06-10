using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bulletScript : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name.StartsWith("Enemy")) {

            Destroy(collision.gameObject);

        }
    }
}