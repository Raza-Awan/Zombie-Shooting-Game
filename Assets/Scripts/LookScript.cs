using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchControlsKit;
using UnityEngine.InputSystem;

public class LookScript : MonoBehaviour
{
    //public PlayerInput playerInput;
    public Transform character;
    public CharacterAiming characterAiming;
    //public CinemachineVirtualCamera virtualCamera;

    public float sensitivity = 1f;
    public float smoothing = 1.5f;
    public float turnSpeed = 15f;
    float rotation;

    Vector2 frameVelocity;
    Vector2 velocity;
    //private InputAction lookAction;

    void Start()
    {
        //lookAction = playerInput.actions["Look"];
    }

    void Update()
    {
        //Vector2 delta = lookAction.ReadValue<Vector2>();
        //Vector2 rawFrameVelocity = Vector2.Scale(delta, Vector2.one * sensitivity);
        //frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        //velocity += frameVelocity;
        //velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        //virtualCamera.transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        //virtualCamera.transform.localRotation = Quaternion.AngleAxis(velocity.y, Vector3.up);
        //character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);


        //-------------------TCK--------

        //characterAiming.xAxis.Update(Time.deltaTime);
        //characterAiming.yAxis.Update(Time.deltaTime);

        ////Vector2 look = TCKInput.GetAxis("Touchpad");
        ////look.x = characterAiming.xAxis.Value;
        ////look.y = characterAiming.yAxis.Value;

        //float lookX = characterAiming.xAxis.Value;
        //float lookY = characterAiming.yAxis.Value;

        //Vector2 lookaxis = new Vector2(lookX, lookY);
        //Vector2 rawFrameVelocity = Vector2.Scale(lookaxis, Vector2.one * sensitivity);
        //frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        //velocity += frameVelocity;
        //velocity.y = Mathf.Clamp(velocity.y, -45, 45);

        //transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        //character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);

        ////Vector2 look = TCKInput.GetAxis("Touchpad");
        ////PlayerRotation(look.x, look.y);
        ////character.localRotation = Quaternion.AngleAxis(look.x, Vector3.up);

        //float yCam = transform.rotation.eulerAngles.y;
        ////yCam = Mathf.Clamp(0, -45, 45);
        //character.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yCam, 0), turnSpeed * Time.fixedDeltaTime);
    }

    void FixedUpdate()
    {
        //characterAiming.xAxis.Update(Time.fixedDeltaTime);
        //characterAiming.yAxis.Update(Time.fixedDeltaTime);

        //float lookX = characterAiming.xAxis.Value;
        //float lookY = characterAiming.yAxis.Value;

        //Vector2 lookaxis = new Vector2(lookX * 0.5f, lookY * 0.5f);
        //Vector2 rawFrameVelocity = Vector2.Scale(lookaxis, Vector2.one * sensitivity);
        //frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        //velocity += lookaxis * sensitivity;
        //velocity.y = Mathf.Clamp(velocity.y, -20, 30);

        //transform.localRotation = Quaternion.AngleAxis(-velocity.y, -Vector3.right);
        //character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);

        //float yCam = transform.rotation.eulerAngles.y;
        //yCam = Mathf.Clamp(0, -45, 45);
        //character.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yCam, 0), turnSpeed * Time.fixedDeltaTime);
    }

    //public void PlayerRotation(float horizontal, float vertical)
    //{
    //    character.Rotate(0f, horizontal * 12f, 0f);
    //    rotation += vertical * 12f;
    //    rotation = Mathf.Clamp(rotation, -60f, 60f);
    //    transform.localEulerAngles = new Vector3(-rotation, transform.localEulerAngles.y, 0f);
    //    //character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);

    //    float yCam = Camera.main.transform.rotation.eulerAngles.y;
    //    character.rotation = Quaternion.Slerp(character.rotation, Quaternion.Euler(0, yCam, 0), sensitivity * Time.fixedDeltaTime);
    //}
}
