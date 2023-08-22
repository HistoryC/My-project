using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            Vector3 newPos = Vector3.right + transform.position;
            Vector3 pos = this.GetComponent<Transform>().transform.position = Vector3.Lerp(this.transform.position, newPos, speed);
            
            
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            Vector3 newPos = Vector3.left + transform.position;;
            Vector3 pos = this.GetComponent<Transform>().transform.position = Vector3.LerpUnclamped(this.transform.position, newPos, speed);
        }
    }
}
