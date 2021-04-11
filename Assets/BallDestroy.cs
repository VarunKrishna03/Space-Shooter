using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Ball")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
    private void Update()
    {
        
    }
}

