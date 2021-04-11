using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawn : MonoBehaviour
{
    public GameObject brick;
    public float offset;
    public GameObject[] brickArray;
    float y = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        brickArray = new GameObject[7];
        float x = transform.position.x+2.0f;
        for (int j = 0; j < 2; j++)
        {

            for (int i = 0; i < brickArray.Length; i++)
            {
                transform.position = new Vector3(x, y, 0);
                brickArray[i] = Instantiate(brick, transform.position, Quaternion.identity);
                x = x + 2.0f;
            }
            for (int k = 0; k < 3;)
            {
                int randValue = Random.Range(0, brickArray.Length);
                if (brickArray[randValue].tag != "SuperBrick")
                {
                    brickArray[randValue].tag = "SuperBrick";
                    k++;
                }
            }  
                y--;
                x = x - 14;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
