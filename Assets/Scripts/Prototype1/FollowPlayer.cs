using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]  GameObject player; //creating a variable for gameobject to follow

    private Vector3 offset = new Vector3(0, 5, -7); //creating a vector3 offset variable, for the minimum distance to maintained by camera
    // Start is called before the first frame update
    void Start()
    {
        // Ensure the camera starts at the correct position
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void LateUpdate() //changing this to lates update cuz PlayerController script has update function,
                      //hence the vehicle is moving 1st and then camera is supposed to move hence, changing to lateupdate
                      //this will fix the stutter issue as well
    {
        // Update the camera's position and rotation to follow the player with the same offset
        transform.position = player.transform.position + player.transform.TransformDirection(offset);
        
        //In the Quaternion.LookRotation() method, the forward parameter specifies the direction the camera should face,
        //while the up parameter specifies the upward direction for the camera.
        //By using Vector3.up, we ensure that the camera maintains an upright orientation even as it follows the player.
        transform.rotation = Quaternion.LookRotation(player.transform.forward, Vector3.up);
    }
}
