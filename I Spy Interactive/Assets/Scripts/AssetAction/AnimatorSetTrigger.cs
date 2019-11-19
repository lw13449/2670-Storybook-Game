using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSetTrigger : MonoBehaviour
{

    public Animator anim;
    public string triggerName;

    public void Set(){

        anim.SetTrigger(triggerName);

    }
}
