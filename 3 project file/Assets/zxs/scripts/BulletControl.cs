using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 1f, 0);

        if (this.transform.position.z > 250)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name.StartsWith("Cubeπ÷ŒÔ"))
        {
            if(collision.gameObject != null)
            {
                Destroy(collision.gameObject);
            }
            //Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

    }
}
