using NaughtyAttributes;
using UnityEngine;

public class AnimatorBinding : MonoBehaviour
{

    [SerializeField, Required] Animator _animator;

    [SerializeField, Required] PlayerMove _move;

    [SerializeField, Required] PlayerAttack _attack;

    [SerializeField, Required] EntityHealth _health;


    [AnimatorParam(nameof(_animator), AnimatorControllerParameterType.Bool)]
    [SerializeField] string _isWalkingBoolParam;

    [AnimatorParam(nameof(_animator), AnimatorControllerParameterType.Trigger)]
    [SerializeField] string _isAttackingTriggerParam, _isGettingHit;

    private void Reset()
    {
        _animator = GetComponent<Animator>();
        _move = GetComponentInParent<PlayerMove>();
        _isWalkingBoolParam = "Walking";
        _attack = GetComponentInParent<PlayerAttack>();
        _isAttackingTriggerParam = "Attack"; 
        _isGettingHit = "GetHit";
    }


    private void Start()
    {
        _attack.OnAttack += _attack_OnAttack;
        _move.OnStartMove += _move_OnStartMove;
        _move.OnStopMove += _move_OnStopMove;
        _health.OnGettingHit += _health_OnGettingHIt;
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


    private void _health_OnGettingHIt()
    {
        _animator.SetTrigger(_isGettingHit);
    }
}
