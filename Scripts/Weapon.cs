using UnityEngine;

/// <summary>
/// A basic weapon script for a 3D game.
/// Handles shooting mechanics like damage, range, and fire rate.
/// </summary>
public class Weapon : MonoBehaviour
{
    [Header("Weapon Settings")]
    public int damage = 10; // The amount of damage this weapon deals.
    public float range = 100f; // The maximum distance the weapon can shoot.
    public float fireRate = 15f; // The number of rounds that can be fired per second.

    [Header("References")]
    public Camera fpsCam; // The camera from which the weapon will fire.

    private float nextTimeToFire = 0f;

    /// <summary>
    /// This method is called once per frame.
    /// It's used for handling input and non-physics related updates.
    /// </summary>
    void Update()
    {
        // Check for the "Fire1" button (default is the left mouse button) and if the fire rate allows shooting again.
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            // Update the time when the player can next fire.
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    /// <summary>
    /// Handles the shooting logic.
    /// </summary>
    private void Shoot()
    {
        // A Raycast is a way of "shooting" a ray from a point in a certain direction
        // to see if it hits any colliders.
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            // If the ray hits something, try to get a Health component from the hit object.
            Health targetHealth = hit.transform.GetComponent<Health>();

            // If the hit object has a Health component, call its TakeDamage method.
            if (targetHealth != null)
            {
                targetHealth.TakeDamage(damage);
            }
        }
    }
}
