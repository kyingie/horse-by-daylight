using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    [SerializeField] private float _interactDistance = 5.0f;
    [SerializeField] private float _runDistance = 5.0f;
    [SerializeField] private Animator _animator;
    [SerializeField] private NavMeshAgent _navAgent;
    [SerializeField] private GameObject _explosionVFX;

    private Transform _playerTransform;
    private bool _wasCaptured;

    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    private void Start()
    {
        _playerTransform = GameObject.FindWithTag("Player").transform;
    }

    // ------------------------------------------------------------------------
    private void Update()
    {
        if (Vector3.Distance(transform.position, _playerTransform.position) <= _interactDistance)
        {
            // Use the GetPositionAwayFromPlayer() method to set this object's
            //      NavMeshAgent destination.
            // If used properly, this will make the NPC run away from the player.
        }

        _animator.SetBool("running", _navAgent.velocity.magnitude > 0.0f);
    }

    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    private Vector3 GetPositionAwayFromPlayer()
    {
        Vector3 awayFromPlayer = transform.position +
            (transform.position - _playerTransform.position).normalized * _runDistance;
        NavMeshHit hit;
        if (NavMesh.SamplePosition(awayFromPlayer, out hit, 1.0f, NavMesh.AllAreas))
        {
            return hit.position;
        }
        return transform.position;
    }
    
    // ------------------------------------------------------------------------
    // You don't need to code anything in this method :)
    public void PickUp ()
    {
        _wasCaptured = true;
        _navAgent.enabled = false;
        enabled = false;
        _animator.SetBool("trapped", true);
    }

    // ------------------------------------------------------------------------
    // Add a built-in Unity method to detect COLLISIONS.
    // IF this NPC was previously captured in the Katamari,
    //      then when it collides with something,
    //      it should explode.
}
