using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickCollision : MonoBehaviour
{
    
    int count = 2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
            if(gameObject.tag=="Brick")
        {
            Destroy(gameObject);
        }
            if(gameObject.tag=="SuperBrick")
        {
            count--;
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);
            if (count==0)
            {
                Destroy(gameObject);
            }
        }
    }
   


}
