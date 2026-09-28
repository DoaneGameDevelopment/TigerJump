using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    /* input system changed and i don't wanna change which version is used so i just converted the
    old version from sidescroller to the new input system using chatgpt but i didn't do the whole thing yet.

    this is what needs to be done in the actual unity editor (i think)(from chatgpt):
    In the Unity Inspector, you can assign a Move action to moveAction.
        The action should be:

        Action Type: Value
        Control Type: Vector2

        Then add bindings such as:

        Input	Binding
        A / D	2D Vector Composite
        Left / Right Arrow	2D Vector Composite
        Gamepad left stick	Left Stick

    i also get to following error and i don't know how to do whatever it asks:
    UnassignedReferenceException: The variable rigidBody of PlayerMovement has not been assigned.
    You probably need to assign the rigidBody variable of the PlayerMovement script in the inspector.
    UnityEngine.Object+MarshalledUnityObject.TryThrowEditorNullExceptionObject (UnityEngine.Object unityObj, System.String parameterName) (at <6a469c5cf96a43eab23a293167261e20>:0)
    UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException (System.Object obj) (at <6a469c5cf96a43eab23a293167261e20>:0)
    UnityEngine.Rigidbody2D.get_linearVelocity () (at <4852adb244664fa0a5f987fef863242e>:0)
    PlayerMovement.Update () (at Assets/PlayerMovement.cs:47)


    */
    public GameObject player;
    public Rigidbody2D rigidBody;
    public float horizSpeed;
    public float vertSpeed; // i'm assuming we need this for later
    public InputAction moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody.freezeRotation = true;   
        moveAction.Enable();     
    }

    // Update is called once per frame
    void Update()
    {
        float Move = moveAction.ReadValue<Vector2>().x;

        rigidBody.linearVelocity = new Vector2(Move * horizSpeed, rigidBody.linearVelocity.y);
    }
}
