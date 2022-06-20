using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionUpdate : MonoBehaviour {
//    [SerializeField] private Transform parent;
    [SerializeField] private Transform eyeCamera;
    [SerializeField] private CharacterController characterController;

    private Vector3 prevPos;
    private float offset;
    private Collider col;

    private void Start() {
        prevPos = eyeCamera.position;
//        offset = (parent.position - characterController.transform.position).y;
        //col = characterController.GetComponent<Collider>();
    }

    private void Update() {
        //characterController.Move(eyeCamera.position - prevPos);
        //prevPos = eyeCamera.position;
        Debug.Log(characterController.center);
        characterController.center = new Vector3(eyeCamera.localPosition.x,0f,eyeCamera.localPosition.z);
        //characterController.center = transform.InverseTransformPoint( new Vector3(eyeCamera.position.x,0f,eyeCamera.position.z));

        //Vector3 d =  parent.position - eyeCamera.position;
        //characterController.center = new Vector3(d.x,0f,d.z);


 //       if (!characterController.isGrounded) {
 //           characterController.Move(Physics.gravity);
//        }

 //       Vector3 pos = parent.position;
 //       pos.y = characterController.transform.position.y + offset;
 //       parent.position = pos;
    }
}