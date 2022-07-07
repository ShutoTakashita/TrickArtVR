using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino; // adding Uduino NameSpace 

public class FloorDisabler : MonoBehaviour
{
    [SerializeField] Collider floorcol;
    [SerializeField] GameObject freefall;
    UduinoManager u; // The instance of Uduino is initialized here
    public int blinkPin = 8;
    [Range(0,5)]
    private Animator anim;

    void Awake(){
        UduinoManager.Instance.pinMode(blinkPin, PinMode.Output);

    }
    void Start()
    {

        anim = freefall.GetComponent<Animator> ();



    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("すり抜けた！");
        anim.SetBool("PlayAnim", true);
        UduinoManager.Instance.digitalWrite(blinkPin, State.HIGH);


        StartCoroutine("wait");
        
        
    }

    // Update is called once per frame

    IEnumerator wait()
    {
        //3秒停止
        yield return new WaitForSeconds(0.3f);
        floorcol.enabled = false;
        yield return new WaitForSeconds(4.0f);

        UduinoManager.Instance.digitalWrite(blinkPin, State.LOW);
    }
    void Update()
    {
        
    }
}
