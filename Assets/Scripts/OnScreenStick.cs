using UnityEngine;
using UnityEngine.InputSystem;
using TouchControlsKit;
using UnityEngine.UI;
using Cinemachine;

public class OnScreenStick : MonoBehaviour
{
    //public PlayerInput playerInput;
    public Transform character;
    //public Image image;
    //public FixedTouchField touchField;
    //public Vector3 offset;
    //public float cameraAim = 5f;
    public CharacterAiming characterAiming;
    //public CinemachineVirtualCamera virtualCamera;
    public float rotationSpeed = 5f;
    private float xRotation;
    private float yRotation;
    protected float cameraAngle;
    protected float cameraAngleSpeed = 1f;

    Quaternion characterTargetRot;
    Quaternion cameraTargetRot;
    public float smoothTime = 5f;
    public float MinimumX = -90F;
    public float MaximumX = 90F;
    //bool clampVerticalRotation = true;
    //bool smooth;

    //private InputAction lookAction;

    void Start()
    {
        characterTargetRot = character.localRotation;
        cameraTargetRot = transform.localRotation;

        //lookAction = playerInput.actions["Look"];
    }

    void Update()
    {
        //LookRotation();

        //Vector2 delta = lookAction.ReadValue<Vector2>();

        //characterAiming.xAxis.Update(Time.deltaTime);
        //characterAiming.yAxis.Update(Time.deltaTime);

        //Vector2 look = TCKInput.GetAxis("Touchpad");

        ////float mouseX = 0;
        ////float mouseY = 0;

        //if (Touchscreen.current.name == "TouchPad")
        //{
        //    if (Touchscreen.current.touches.Count > 0 && Touchscreen.current.touches[0].isInProgress)
        //    {
        //        look.x = Touchscreen.current.touches[0].delta.ReadValue().x;
        //        look.y = Touchscreen.current.touches[0].delta.ReadValue().y;
        //    }
        //}

        
        //look.x *= rotationSpeed;
        //look.y *= rotationSpeed;

        //////delta.x = characterAiming.xAxis.Value;
        //////delta.y = characterAiming.yAxis.Value;
        //xRotation -= look.y * Time.deltaTime;
        //yRotation -= look.x * Time.deltaTime;
        //////yRotation = Mathf.Clamp(yRotation, -80, 80);
        //xRotation = Mathf.Clamp(xRotation, -80, 80);
        //////xRotation += delta.x * rotationSpeed * Time.deltaTime;
        //////yRotation += delta.y * rotationSpeed * Time.deltaTime;

        ////transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        //transform.localRotation = (Quaternion.RotateTowards(transform.localRotation, Quaternion.AngleAxis(-xRotation, -Vector3.right), MaximumX * Time.deltaTime))
        //    * (Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0, yRotation, 0), MaximumX * Time.deltaTime));
        ////transform.localRotation = Quaternion.AngleAxis(-look.y, -Vector3.right);
        ////character.localRotation = Quaternion.AngleAxis(look.x, Vector3.up);

        //character.Rotate(Vector3.up * look.x * Time.deltaTime);
        ////player.Rotate(-Vector3.right * mouseY * Time.deltaTime);

        //float yCam = transform.rotation.eulerAngles.y;
        //////yCam = Mathf.Clamp(0, -45, 45);
        //character.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yCam, 0), smoothTime * Time.deltaTime);

        //------------------------------------------------------------------------------------------------


        //Camera.main.transform.position = transform.position + Quaternion.AngleAxis(cameraAngle, Vector3.forward) * 
        //                                 offset;
        //Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * cameraAim - 
        //                                 Camera.main.transform.position, Vector3.up);



        //float mouseX = 0;
        //float mouseY = 0;

        //if (Touchscreen.current.touches.Count > 0 && Touchscreen.current.touches[0].isInProgress)
        //{
        //    mouseX = Touchscreen.current.touches[0].delta.ReadValue().x;
        //    mouseY = Touchscreen.current.touches[0].delta.ReadValue().y;
        //}
        //mouseX *= rotationSpeed;
        //mouseY *= rotationSpeed;

        //characterTargetRot *= Quaternion.Euler(0f, mouseY, 0f);
        //cameraTargetRot *= Quaternion.Euler(-mouseX, 0f, 0f);

        //if (clampVerticalRotation)
        //{
        //    cameraTargetRot = ClampRotationAroundXAxis(cameraTargetRot);
        //}

        //if (smooth)
        //{
        //    character.localRotation = Quaternion.Slerp(character.localRotation, characterTargetRot, smoothTime * Time.deltaTime);
        //    transform.localRotation = Quaternion.Slerp(transform.localRotation, cameraTargetRot, smoothTime * Time.deltaTime);
        //}
        //else
        //{
        //    character.localRotation = characterTargetRot;
        //    transform.localRotation = cameraTargetRot;
        //}
    }

    //public void LookRotation()
    //{
    //    float yRot = SimpleInput.GetAxis("LookX") * rotationSpeed;
    //    float xRot = SimpleInput.GetAxis("LookY") * rotationSpeed;

    //    characterTargetRot *= Quaternion.Euler(0f, yRot, 0f);
    //    cameraTargetRot *= Quaternion.Euler(-xRot, 0f, 0f);

    //    if (clampVerticalRotation)
    //        cameraTargetRot = ClampRotationAroundXAxis(cameraTargetRot);

    //    if (smooth)
    //    {
    //        character.localRotation = Quaternion.Slerp(character.localRotation, characterTargetRot,
    //            smoothTime * Time.deltaTime);
    //        transform.localRotation = Quaternion.Slerp(transform.localRotation, cameraTargetRot,
    //            smoothTime * Time.deltaTime);
    //    }
    //    else
    //    {
    //        character.localRotation = characterTargetRot;
    //        transform.localRotation = cameraTargetRot;
    //    }
    //}

    //Quaternion ClampRotationAroundXAxis(Quaternion q)
    //{
    //    q.x /= q.w;
    //    q.y /= q.w;
    //    q.z /= q.w;
    //    q.w = 1.0f;

    //    float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

    //    angleX = Mathf.Clamp(angleX, MinimumX, MaximumX);

    //    q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

    //    return q;
    //}
}



