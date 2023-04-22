using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public GameObject obstale;
    public bool invoking;

    public int time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(Spawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawning()
    {
        while(invoking)
        {
            time = Random.Range(1,3);
            yield return new WaitForSeconds(time);
            Instantiate(obstale, transform.position, Quaternion.identity);
        }
    }
}
