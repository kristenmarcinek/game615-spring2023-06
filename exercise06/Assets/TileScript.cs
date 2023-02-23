using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool isColored = false;
    bool PlayerTile = false;
    bool EnemyTile = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            var tileRenderer = gameObject.GetComponent<Renderer>();
            tileRenderer.material.SetColor("_Color", Color.cyan);
             PlayerTile = true;
             EnemyTile = false;

            //GameManager.playerScore += 1;
        }
        
        if (other.gameObject.CompareTag("Enemy")) {
            var tileRenderer = gameObject.GetComponent<Renderer>();
            tileRenderer.material.SetColor("_Color", Color.magenta);
            PlayerTile = false;
            EnemyTile = true;
            //GameManager.enemyScore += 1;
        }
    }

}
