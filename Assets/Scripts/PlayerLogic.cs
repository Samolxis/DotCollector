using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{

    public float playerSpeed = 10f;
    void Start()
    {
        
    }

  
    void Update()
    {
        MovePlayerToMousePosition();
        HideMouseCursor();
    }

    void MovePlayerToMousePosition ()
    {
        var tempMousePosition = Input.mousePosition; // screen width and height
        tempMousePosition.z = transform.position.z - Camera.main.transform.position.z;
        tempMousePosition = Camera.main.ScreenToWorldPoint(tempMousePosition);
        transform.position = Vector3.MoveTowards(transform.position, tempMousePosition, playerSpeed * Time.deltaTime);
    }

    void HideMouseCursor ()
    {
        Cursor.visible = false;
    }
}
