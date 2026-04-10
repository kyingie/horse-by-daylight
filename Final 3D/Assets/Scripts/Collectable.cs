using UnityEngine;

// Add an enum to represent an item's rarity.

public class Collectable : MonoBehaviour
{
    // Add a member varible to represent each collectable's rarity. Make sure
    //      it can be tuned from the Inspector.

    private Collider[] _colliders;
    private Rigidbody _rigidbody;
    private GameController _gameController;

    // ------------------------------------------------------------------------
    private void Start ()
    {
        _gameController = FindFirstObjectByType<GameController>();
    }

    // ------------------------------------------------------------------------
    // You might want to add parameters to this method.
    public void Collect ()
    {
        // Set the new parent and position of the Collectable.
        // Disable all of this object's colliders.

        // This line sets the rigidbody to kinematic so it'll stop using physics.
        // (You don't need to change this.)
        _rigidbody.isKinematic = true;

        // Tell the GameController that we collected this item.
    }

    // ------------------------------------------------------------------------
    // You might want to add parameters to this method.
    public void Drop ()
    {
        // Reset this object's parent so it's no longer attached to the Katamari,
        //  and give it a new position ABOVE the Katamari sphere.
        

        // Enable all of this object's colliders.
        

        // This line sets the rigidbody to kinematic so it'll start using physics again.
        // (You don't need to change this.)
        _rigidbody.isKinematic = false;

        // Add a force to the rigidbody to make it fly upwards.

        // Tell the UI that we removed this item.
        
    }
}