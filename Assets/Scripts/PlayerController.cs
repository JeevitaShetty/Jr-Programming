using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    //creating variable to give the vehicle some speed, turnSpeed, left/right movement variable
    [SerializeField] private float speed, turnSpeed ;
    private float horizontalInput, verticalInput;
    
    public int numberOfGems { get; private set; }
    public UnityEvent<PlayerController> OnCollected;

    public void DiamondCollected()
    {
        numberOfGems++;
        OnCollected.Invoke(this);
        ;
    }
}
