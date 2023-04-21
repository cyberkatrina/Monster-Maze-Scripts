using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public bool catTalked = false;
    public GameObject uiObject;
    public Renderer rend;

// Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            catTalked = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.tag == "Player" && catTalked == true)
            {
                uiObject.SetActive(true);
                rend.enabled = false;
                StartCoroutine("WaitForSec");
            }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        uiObject.SetActive(false);
        Destroy(uiObject);
        Destroy(gameObject);
    }    
}
