using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    //gameObject gme;
    public float forwardSpeed=50;
    public float rotateSpeed=25;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
        
        }
        if (Input.GetKey(KeyCode.D)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        gameObject.transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0, Space.Self);
        //forwardSpeed += .1f;
        }
        if (Input.GetKey(KeyCode.A)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime *-1, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.S)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime*-1, Space.World);
        
        } 
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Tile")) {
            var tileRenderer = other.gameObject.GetComponent<Renderer>();
            tileRenderer.material.SetColor("_Color", Color.cyan);
            //GameManager.playerScore += 1;
        }
    }
}