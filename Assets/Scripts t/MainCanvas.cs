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

        //Delete all already existing previews in the scene
        GameObject[] previews = GameObject.FindGameObjectsWithTag("Preview");
        for(int i = 0; i <= previews.Length - 1;)
        {
            if(previews[i] != null)
            {
                previews[i].gameObject.GetComponent<Preview>().Kys();
            }
            i++;
        }
    }

    void CursorPos()
    {
        mousePos = new Vector3((Input.mousePosition.x - Screen.width/2) / (((Screen.width / 46) / 15.93f) * 9), 0, (Input.mousePosition.y - Screen.height/2) / (Screen.height / 45.7f));
    }

}
