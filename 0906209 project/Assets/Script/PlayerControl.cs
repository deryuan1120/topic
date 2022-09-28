using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController player_control;
    public float move_speed = 1f;
    public float walking_speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        player_control = transform.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                walking_speed = 2f;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                walking_speed = 1f;
            }
        }
    }

    private void PlayerMove()
    {
        var h_move = Input.GetAxis("Horizontal");
        var v_move = Input.GetAxis("Vertical");
        var d = new Vector3(h_move, -10, v_move);
        var move = transform.TransformDirection(d) * move_speed * walking_speed * Time.deltaTime;
        player_control.Move(move);
    }
}
    
