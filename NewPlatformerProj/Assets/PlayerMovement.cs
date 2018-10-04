using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    float horizontal = 0f;

    public float runSpd = 40f;

	// Update is called once per frame
	void Update () {

        horizontal = Input.GetAxisRaw("Horizontal") * runSpd;
	}

    private void FixedUpdate()
    {
        // Moves Character
        controller.Move(horizontal * Time.fixedDeltaTime, false, false);
    }
}
