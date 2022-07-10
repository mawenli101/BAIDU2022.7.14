using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl : MonoBehaviour
{
    public GameObject monster_prefeb;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateMonster", 0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateMonster()
    {
        float range = 100f;
        float random_float = Random.Range(-range, range);
        GameObject monster = Instantiate(monster_prefeb);
        monster.transform.position = new Vector3(random_float, 0, 200f);
        //int num = Random.Range(0, images.Length);
        //monster.GetComponent<SpriteRenderer>().sprite = images[num];
    }
}
