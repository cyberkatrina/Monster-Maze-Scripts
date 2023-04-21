using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public bool catTalked = false;
    // public FloatingTextManager floatingTextManager;
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

    // public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    //     {
    //         floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    //     }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if (Input.GetKeyDown(KeyCode.Return))
        // {
            if (collision.tag == "Player" && catTalked == true)
            {
                uiObject.SetActive(true);
                //Destroy(gameObject);
                rend.enabled = false;
                StartCoroutine("WaitForSec");
                // ShowText("Congratulations! You found your cat", 36, Color.white, transform.position, Vector3.up * 50, 3.0f);
            }
        // }
    }

    IEnumerator WaitForSec()
    {
        //gameObject.SetActive(false);
        yield return new WaitForSeconds(5);
        uiObject.SetActive(false);
        Destroy(uiObject);
        Destroy(gameObject);
    }


    
}
