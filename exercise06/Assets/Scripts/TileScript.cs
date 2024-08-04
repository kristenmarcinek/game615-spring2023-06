using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        // Debug.Log($"OnTriggerEnter called. other's tag was {other.tag}.");
        if (other.gameObject.CompareTag("Player")) {
            var tileRenderer = gameObject.GetComponent<Renderer>();
            tileRenderer.material.SetColor("_Color", Color.cyan);
        }
        
        if (other.gameObject.CompareTag("Enemy")) {
            var tileRenderer = gameObject.GetComponent<Renderer>();
            tileRenderer.material.SetColor("_Color", Color.magenta);
        }
    }

}
