using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    private int buildingSelected;

    public Vector3 mousePos {get; private set;}

    [SerializeField] private Vector3 MousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CursorPos();
        MousePos = mousePos;
    }

    public void SelectBuilding(int building)
    {
        buildingSelected = building;
    }

    void CursorPos()
    {
        mousePos = new Vector3((Input.mousePosition.x - Screen.width/2) / (((Screen.width / 46) / 15.93f) * 9), 0, (Input.mousePosition.y - Screen.height/2) / (Screen.height / 45.7f));
        Debug.Log(Screen.height + " and: " + Screen.width);
    }

}
