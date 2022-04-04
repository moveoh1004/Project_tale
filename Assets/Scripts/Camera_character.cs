using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_character : MonoBehaviour
{
    public GameObject DummyModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = DummyModel.transform.position + new Vector3(0,5.5f,-8);
    }
}
