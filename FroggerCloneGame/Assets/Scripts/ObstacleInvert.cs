using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInvert : MonoBehaviour
{
    public int velocity;
    // Start is called before the first frame update
    void Start()
    {
       velocity = Random.Range(7,13); 
    }

    // Update is called once per frame
    void Update()
    {
        
        ObstacleWalk();
    }
    public void ObstacleWalk()
    {
        transform.Translate(-velocity * Time.deltaTime,0,0 );
    }

    private void OnTriggerEnter2D(Collider2D collidend) 
    {
        if (collidend.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}
