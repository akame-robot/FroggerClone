using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        PlayerMovement();
        if (transform.position.x <= -11.55)
        {
            transform.position = new Vector3 (-11.54f, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= 11.55)
        {
            transform.position = new Vector3 (11.54f, transform.position.y, transform.position.z);
        }
    }

    public void PlayerMovement()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Move(Vector3.up);
        }
        else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Move(Vector3.down);
        }
        else if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move(Vector3.left);
        }
        else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(Vector3.right);
        }
        
    }
    public void Move(Vector3 direction)
    {
        transform.position += direction;
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Debug.Log($"colidiu");
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
}
