using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatTrigger : MonoBehaviour
{
    public GameObject CatController;

    // Start is called before the first frame update
    void Start()
    {
        CatController.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") 
        {
            CatController.SetActive(true);
            print("working");
        }
    }
}
