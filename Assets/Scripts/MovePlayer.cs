using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    private CharacterController controller;
    
    private PlayerInput input;

    private MeshRenderer meshRenderer;

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Material yellow;
    [SerializeField] private Material green;
    [SerializeField] private Material blue;
    [SerializeField] private Material red;
    [SerializeField] private Material white;
    [SerializeField] private Material black;

    private Vector2 movement;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        controller.Move(new Vector3(movement.x,0,movement.y) * Time.deltaTime * moveSpeed);
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnYellow(InputAction.CallbackContext context)
    {
        if (context.performed)
            meshRenderer.material = yellow;
    }

    public void OnGreen(InputAction.CallbackContext context)
    {
        if (context.performed)
            meshRenderer.material = green;
    }

    public void OnBlue(InputAction.CallbackContext context)
    {
        if (context.performed)
            meshRenderer.material = blue;
    }

    public void OnRed(InputAction.CallbackContext context)
    {
        if (context.performed)
            meshRenderer.material = red;
    }

    public void OnWhite(InputAction.CallbackContext context)
    {
        if (context.performed)
            meshRenderer.material = white;
    }

    public void OnBlack(InputAction.CallbackContext context)
    {
        if (context.performed)
            meshRenderer.material = black;
    }
}
