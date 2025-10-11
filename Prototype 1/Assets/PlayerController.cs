using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed = 30f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Makes vehicle move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed *forwardInput);

        //Makes vehicle rotate
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        //Gather input from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

    }
}
