using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public Animator anim;

    public void CommandActions(string Commands) {
        Commands = Commands.Trim();

        switch (Commands) {

            case "running":
                anim.SetBool("stop", false);
                anim.Play("Run");
                break;
            case "jump":
                anim.Play("Jump");
                break;
            case "stop":
                anim.SetBool("stop",true);
                break;
            default:
                anim.Play("Idle");
                break;
        }
    }
}
