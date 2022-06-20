using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMDRotationUpdate : MonoBehaviour {
//    [SerializeField] private Transform parent;
    [SerializeField] private GameObject Root;
    [SerializeField] private GameObject CenterEye;

     [SerializeField] private GameObject trackingspace;


    private void Start() {

    }

    private void Update() {
        float eyeY = CenterEye.transform.rotation.eulerAngles.y;
        Debug.Log(eyeY);

        Vector3 prevPos = trackingspace.transform.position;
        Quaternion prevRot = trackingspace.transform.rotation;

        Root.transform.rotation = Quaternion.Euler(0.0f, eyeY, 0.0f);

        trackingspace.transform.position = prevPos;
        trackingspace.transform.rotation = prevRot;

    }
}