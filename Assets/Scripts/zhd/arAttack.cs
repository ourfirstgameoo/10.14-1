using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arAttack : MonoBehaviour
{

    public GameObject prefeb;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1  &&  Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Debug.Log("get mousedown");
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit, 500))
            {
                if (hit.transform.gameObject.GetComponent<Building>() != null)
                {
                    GameObject.Instantiate<GameObject>(prefeb,hit.transform);
                    
                }
            }
        }
    }
}
