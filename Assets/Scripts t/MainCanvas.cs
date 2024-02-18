using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    public int buildingSelected {get; private set;}
    public bool buildMode {get; private set;}

    public Vector3 mousePos {get; private set;}

    [SerializeField] private Vector3 MousePos;
    [SerializeField] private GameObject exitBuildModeButton;
    public GameObject[] previewPrefabs;
    public GameObject[] buildingPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        buildMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        CursorPos();
        MousePos = mousePos;

        //Handle BuildMode UI
        if(buildMode)
        {
            exitBuildModeButton.SetActive(true);
        }
        else
        {
            exitBuildModeButton.SetActive(false);
        }
    }

    public void SelectBuilding(int building)
    {
        buildingSelected = building;

        //enable building mode
        buildMode = true;

        //Replace previous preview
        GameObject[] previews = GameObject.FindGameObjectsWithTag("Preview");
        for(int i = 0; i <= previews.Length - 1;)
        {
            if(previews[i] != null)
            {
                previews[i].gameObject.GetComponent<Preview>().Kys();
            }
            i++;
        }
        Instantiate(previewPrefabs[buildingSelected - 1], mousePos, previewPrefabs[buildingSelected - 1].transform.rotation);
    }

    void CursorPos()
    {
        mousePos = new Vector3((Input.mousePosition.x - Screen.width/2) / (((Screen.width / 46) / 15.93f) * 9), 0, (Input.mousePosition.y - Screen.height/2) / (Screen.height / 45.7f));
    }

    public void ExitBuildMode()
    {
        buildMode = false;

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
}
