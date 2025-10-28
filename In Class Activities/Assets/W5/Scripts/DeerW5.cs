using UnityEngine;
using UnityEngine.AI;

// The ": MonoBehaviour" after the class name is what makes it useable as a Component.
public class DeerW5 : MonoBehaviour
{
    // This is a member variable.
    // The "[SerializeField] private" is what makes this variable tunable from
    //      the Inspector.
    // "Transform" defines the type of this variable - it's a Transform, the
    //      Component that stores each GameObject's position, rotation, and scale.
    [SerializeField] private Transform _destination;
    // ------------------------------------------------------------------------
    // The Start method is called when the game begins.
    private void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_destination.position);
    }
}
