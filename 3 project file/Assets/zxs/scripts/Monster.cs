using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    private int flag_direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num = Random.Range(0, 4);//�����0123

        if (flag_direction == 0)
        {
            this.transform.Translate(0, 0, -0.5f);
        }
        if (flag_direction == 1)
        {
            this.transform.Translate(0, 0, 0.5f);
        }
        if (this.transform.position.z < 50)
        {
            flag_direction = 1;
        }
        if (this.transform.position.z > 250)
        {
            flag_direction = 0;
        }

        /*
        if (this.transform.position.z < 0)
        {
            GameObject.Destroy(this.gameObject);
        }
        */

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name.StartsWith("Cubu�Լ�"))
        {
            Destroy(this.gameObject);

            GameObject main = GameObject.Find("��Ϸ����");
            MyGame my_game = main.GetComponent<MyGame>();
            my_game.AddScore();
        }

    }
}
