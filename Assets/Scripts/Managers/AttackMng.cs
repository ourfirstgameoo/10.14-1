using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AttackMng : MonoSingleton<AttackMng>
{
    public GameObject currentBuilding = null;

    public Camera captureCamera;

    public Canvas informationCanvas;


    private RawImage RI;
    private Button[] opeButton = new Button[2];
    private Text title;



    public Vector3 cameraOffset = new Vector3(0, 300f, 300f);

    private RenderTexture captureImage;
    

    // Start is called before the first frame update
    void Start()
    {
        RI = informationCanvas.GetComponentInChildren<RawImage>();
        opeButton = informationCanvas.GetComponentsInChildren<Button>();
        title = informationCanvas.GetComponentInChildren<Text>();


        informationCanvas.gameObject.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setCurrentBuilding(GameObject go)
    {
        //building
        currentBuilding = go;
        //change layer
        currentBuilding.layer = 17;

        
        
    }

    void setOverviewImage()
    {
        captureCamera.transform.position = currentBuilding.transform.position + cameraOffset;
        captureCamera.transform.LookAt(currentBuilding.transform);
        captureCamera.targetTexture = captureImage;

        

    }

    public void openCanvas(int operation)
    {
        // 0 is attack , 1 is defense

        if (operation == 0)
            opeButton[1].GetComponentInChildren<Text>().text = "attack";
        else if (operation == 1)
            opeButton[1].GetComponentInChildren<Text>().text = "defense";


        setOverviewImage();
        RI.texture = captureImage;

        title.text = currentBuilding.GetComponent<Building>().attr.name;
        informationCanvas.gameObject.SetActive(true);
        
    }
    public void closeCanvas()
    {
        informationCanvas.gameObject.SetActive(false);
    }


}
