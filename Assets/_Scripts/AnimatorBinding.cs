using NaughtyAttributes;
using UnityEngine;

public class AnimatorBinding : MonoBehaviour
{

    [SerializeField, Required] Animator _animator;

    [SerializeField, Required] PlayerMove _move;

    [SerializeField, Required] PlayerAttack _attack;


    [AnimatorParam(nameof(_animator), AnimatorControllerParameterType.Bool)]
    [SerializeField] string _isWalkingBoolParam;

    [AnimatorParam(nameof(_animator), AnimatorControllerParameterType.Trigger)]
    [SerializeField] string _isAttackingTriggerParam;

    private void Reset()
    {
        _animator = GetComponent<Animator>();
        _move = GetComponentInParent<PlayerMove>();
        _isWalkingBoolParam = "Walking";
        _attack = GetComponentInParent<PlayerAttack>();
        _isWalkingBoolParam = "Attack";
    }


    private void Start()
    {
        _attack.OnAttack += _attack_OnAttack;
        _move.OnStartMove += _move_OnStartMove;
        _move.OnStopMove += _move_OnStopMove;
    }

    private void _move_OnStartMove()
    {
        _animator.SetBool(_isWalkingBoolParam, true);
    }

    private void _move_OnStopMove()
    {
        _animator.SetBool(_isWalkingBoolParam, false);
    }

    private void _attack_OnAttack()
    {
        _animator.SetTrigger(_isAttackingTriggerParam);
    }

}
