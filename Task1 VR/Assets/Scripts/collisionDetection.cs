using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection : MonoBehaviour
{
    public int mass;
    public AudioSource crashAudio;
    public GameObject objectName;
    public GameObject plane;
    public Rigidbody Rigbody;
    // Start is called before the first frame update
    void Start()
    {
        crashAudio = GetComponent<AudioSource>();
        objectName.name = "Cube";
     //Print Rigidbody Mass
        Rigbody = GetComponent<Rigidbody>();
        Rigbody.mass = mass;
    //Conversion float to int
        int iValue = Mathf.CeilToInt(Rigbody.mass);
        Debug.Log(objectName.name + " mass is "+ iValue);
    }

    // Update is called once per frame
    void Update()
    {
    }
    //collision script
    private void OnCollisionEnter(Collision collision)
    {
        crashAudio.Play();
        Debug.Log(objectName.name + " collided with " + collision.gameObject.name );
    }
}