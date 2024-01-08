using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = new Vector3((Input.mousePosition.x - Screen.width/2) / 13.5f, 0, (Input.mousePosition.y - Screen.height/2));
        transform.position = mousePos;

        Debug.Log(mousePos);
    }
}
