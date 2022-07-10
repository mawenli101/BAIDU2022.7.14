using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addcharacter : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Awake()
    {
         prefab = GameObject.Find("Character");
    }
    void Start()
    {
        GameObject prefabInstance = Instantiate(prefab);
        prefab.SetActive(false);
        prefabInstance.transform.parent = this.transform;
        prefabInstance.transform.localPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
