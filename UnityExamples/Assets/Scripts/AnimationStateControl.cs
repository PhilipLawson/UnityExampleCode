using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateControl : MonoBehaviour
{
    Animator animator;
    int isWalkingForwardHash;
    int isWalkingBackwardHash;
    int isCrouchingHash;
    int isJumpingHash;
    int isSpinningAttackHash;
    int isDeadHash;
    bool p1ControlsReversed = false;
    bool p2ControlsReversed = true;
    public GameObject sword;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sword.GetComponent<Rigidbody>().isKinematic = true;
        isWalkingForwardHash = Animator.StringToHash("ForwardPressed");
        isWalkingBackwardHash = Animator.StringToHash("BackPressed");
        isCrouchingHash = Animator.StringToHash("isCrouching");
        isJumpingHash = Animator.StringToHash("isJumping");
        isSpinningAttackHash = Animator.StringToHash("BackAndAttack");
        isDeadHash = Animator.StringToHash("isDead");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalkingForward = animator.GetBool(isWalkingForwardHash);
        bool isWalkingBackward = animator.GetBool(isWalkingBackwardHash);
        bool isCrouching = animator.GetBool(isCrouchingHash);
        bool isJumping = animator.GetBool(isJumpingHash);
        bool isDead = animator.GetBool(isDeadHash);
        bool isSpinningAttacking = animator.GetBool(isSpinningAttackHash);
        bool forwardPressed = (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow));
        bool backwardPressed = (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow));
        bool crouchPressed = (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow));
        bool isJumpingPressed = (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow));
        bool isDeadPressed = (Input.GetKey(KeyCode.K));
        bool isSpingAttackPressed = (Input.GetKey(KeyCode.Space)) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow));

        //Walking Forward
        if(!isWalkingForward && forwardPressed)
        {
            animator.SetBool(isWalkingForwardHash, true);
        }
        else if (isWalkingForward && !forwardPressed)
        {
            animator.SetBool(isWalkingForwardHash, false);
        }

        //Walking Back
        if(!isWalkingBackward && backwardPressed)
        {
            animator.SetBool(isWalkingBackwardHash, true);
        }
        else if (isWalkingBackward && !backwardPressed)
        {
            animator.SetBool(isWalkingBackwardHash, false);
        }

        //Crouching
        if(!isCrouching && crouchPressed)
        {
            animator.SetBool(isCrouchingHash, true);
        }
        else if (isCrouching && !crouchPressed)
        {
            animator.SetBool(isCrouchingHash, false);
        }

        //Jumping
        if(!isJumping && isJumpingPressed)
        {
            animator.SetBool(isJumpingHash, true);
        }
        else if (isJumping && !isJumpingPressed)
        {
            animator.SetBool(isJumpingHash, false);
        }

        //Sping Attack
        if(!isSpinningAttacking && isSpingAttackPressed)
        {
            animator.SetBool(isSpinningAttackHash, true);
        }
        else if (isSpinningAttacking && !isSpingAttackPressed)
        {
            animator.SetBool(isSpinningAttackHash, false);
        }

        // Death
        if(!isDead && isDeadPressed)
        {
            animator.SetBool(isDeadHash, true);
            Invoke("unParentSword", 1.3f);
        }
        else if (isDead && !isDeadPressed)
        {
            animator.SetBool(isDeadHash, false);
        }
    }

    void unParentSword()
    {
        sword.gameObject.transform.parent = null;
        sword.GetComponent<Rigidbody>().isKinematic = false;
        sword.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-2.0f, 2.0f),1.0f,0.0f);
    }
}
