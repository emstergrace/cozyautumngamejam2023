using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideWall : MonoBehaviour
{
    private GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.FindGameObjectWithTag("Wall");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            wall.SetActive(false);
        }
    }
}
