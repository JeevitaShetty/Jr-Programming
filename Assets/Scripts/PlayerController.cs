using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //creating variable to give the vehicle some speed, turnSpeed, left/right movement variable
    [SerializeField] private float speed, turnSpeed ;
    private float horizontalInput, verticalInput;
    
    public int numberOfDiamonds { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // run every frame and keeps checking in, compiler keeps checking if it needs to do anything etc
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //calling the horizontal axis from the input manager (edit-> input manager-> input manager
        //verticalInput = Input.GetAxis("Vertical");
        
        //Move vehicle forward
       // transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //gameobject will move 60m in z direction,
                                                                               //using time.delta so the frames are not dependent on eachother
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);                                                                       
        
    }

    public void DiamondCollected()
    {
        numberOfDiamonds++;
    }
}
