using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed=10f;
    public float xRange=10;

    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x<-xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        if(transform.position.x>xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        horizontalInput=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*horizontalInput*speed);

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, transform.position,projectilePrefab.transform.rotation);//复制已存在的物体
        }
    }
}
