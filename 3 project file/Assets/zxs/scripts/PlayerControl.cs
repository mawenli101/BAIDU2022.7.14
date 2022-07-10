using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //public GameObject bullet_prefeb;

    private float count_time = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count_time = count_time + Time.deltaTime;
        if (count_time > 1.5)
        {
            count_time = 0;
            //GameObject bullet = Instantiate(bullet_prefeb);
            //bullet.transform.position = this.transform.position + Vector3.forward*5;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, 1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -1f);
        }
    }
}
