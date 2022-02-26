/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-09-23 15:00:26
* @Last Modified by:   
* @Last Modified time: 2021-11-09 15:35:55
*
*           ____                      ,
*          /---.'.__             ____//
*               '--.\           /.---'
*          _______  \\         //
*        /.------.\  \|      .'/  ______
*       //  ___  \ \ ||/|\  //  _/_----.\__
*      |/  /.-.\  \ \:|< >|// _/.'..\   '--'
*         //   \'. | \'.|.'/ /_/ /  \\
*        //     \ \_\/" ' ~\-'.-'    \\
*       //       '-._| :H: |'-.__     \\
*      //           (/'==='\)'-._\     ||
*      ||                        \\    \|
*      ||                         \\    '
*      |/                          \\
*                                   ||
*                                   ||
*                                   \\
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Destroy(animator.gameObject, stateInfo.length);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    // override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    // {  
    // }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
