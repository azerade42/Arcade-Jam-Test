using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    private GameObject objectToFollow;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position;
        objectToFollow = player1;
    }

    public void SwapToPlayer1(InputAction.CallbackContext context)
    {
        objectToFollow = player1;
    }

    public void SwapToPlayer2(InputAction.CallbackContext context)
    {
        objectToFollow = player2;
    }
    
    private void LateUpdate()
    {
        transform.position = offset + objectToFollow.transform.position;
    }
}
