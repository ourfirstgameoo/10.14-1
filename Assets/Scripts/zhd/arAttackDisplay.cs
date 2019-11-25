using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arAttackDisplay : MonoBehaviour
{

    public GameObject displayingItem = null;

    // Start is called before the first frame update
    void Awake()
    {
        displayingItem = AttackMng.Instance.currentBuilding;
    }

    // Update is called once per frame
    void Update()
    {


    }

}
