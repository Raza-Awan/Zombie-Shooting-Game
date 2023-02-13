using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.InputSystem;

public class CharacterAiming : MonoBehaviour
{
    public float turnSpeed = 15f;
    public Rig aimLayer;
    public float aimDuration = 0.3f;
    public Transform cameraLookAt;
    public Vector2 look;
    public Vector2 move;
    public float pauseTime = 0.1f;
    public GameObject gunSound;
    [HideInInspector] public bool Sound = false;

    Animator animator;
    PlayerInput playerInput;
    RaycastWeapon weapon;

    private InputAction aimAction;
    private InputAction fireAction;

    int isAimingPara = Animator.StringToHash("isAiming");

    void Start()
    {
        animator = GetComponent<Animator>();
        weapon = GetComponentInChildren<RaycastWeapon>();
        playerInput = GetComponent<PlayerInput>();
        gunSound.SetActive(false);

        fireAction = playerInput.actions["Fire"];
        aimAction = playerInput.actions["Aim"];

        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (aimAction.inProgress)
        {
            animator.SetBool(isAimingPara, true);
        }
        else
        {
            animator.SetBool(isAimingPara, false);
        }
    }

    void OnLook(InputValue value)
    {
        look = value.Get<Vector2>();
    }
    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }


    private void LateUpdate()
    {
        //if (aimLayer)
        //{
        //    if (Input.GetButton("Fire2"))
        //    {
        //        aimLayer.weight += Time.deltaTime / aimDuration;
        //    }
        //    else
        //    {
        //        aimLayer.weight -= Time.deltaTime / aimDuration;
        //    }
        //}


        if (fireAction.inProgress)
        {
            weapon.StartFiring();
            ReadySound();
            Sound = true;
        }
        else
        {
            weapon.StopFiring();
            Sound = false;
            gunSound.SetActive(false);
        }
        if (weapon.isFiring)
        {
            weapon.UpdateFiring(Time.deltaTime);
        }
        weapon.UpdateBullets(Time.deltaTime);
    }

    void ReadySound()
    {
        StartCoroutine(StartSound());
        gunSound.SetActive(true);
    }

    IEnumerator StartSound()
    {
        yield return new WaitForSeconds(pauseTime);
        if (Sound == true)
        {
            ReadySound();
        }
    }
}
