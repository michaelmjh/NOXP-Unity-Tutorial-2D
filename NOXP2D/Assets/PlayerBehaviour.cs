using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float maxDistanceToTravel = speed * Time.deltaTime;

        transform.position += Vector3.up * Input.GetAxis("Vertical") * speed;
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed;
    }
}
