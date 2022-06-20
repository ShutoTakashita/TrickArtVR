using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDisabler : MonoBehaviour
{
    [SerializeField] Collider floorcol;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("すり抜けた！");
        floorcol.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
