using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = GameObject.Find("Canvas").GetComponent<MainCanvas>().mousePos;
        transform.position = mousePos;
    }
}
