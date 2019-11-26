﻿#if PLANNER_ACTIONS_GENERATED
using System;
using UnityEngine;
using Workaholic;

public class SleepStop_State : StateMachineBehaviour
{

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var gameObject = animator.gameObject;
        var motionController = gameObject.GetComponentInChildren<MotionController>();
        motionController.TargetOrientation = gameObject.transform.forward;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var otto = animator.gameObject.GetComponentInChildren<Otto>();
        var action = (SleepAction)otto.CurrentOperationalAction;
        action.AnimationComplete = true;
    }
}
#endif
