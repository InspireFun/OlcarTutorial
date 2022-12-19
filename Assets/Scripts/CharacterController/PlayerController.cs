using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;

    public float speed = 10f;


    void Start()
    {
        characterController = GetComponent<CharacterController>();  
    }

    
    void Update()
    {
        Vector3 pos = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical")).normalized;

        characterController.Move(pos*speed*Time.deltaTime);
    }
}
