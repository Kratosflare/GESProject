using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject shooterPrefab;
    float horizontalInput;
    float verticalInput;
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       // verticalInput = Input.GetAxis("Vertical");

     //   transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shooterPrefab, transform.position, shooterPrefab.transform.rotation);
        }

    }
}
