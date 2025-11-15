using UnityEngine;

/// <summary>
/// A script to manage the health of a game object.
/// Can be attached to players, enemies, or any destructible object.
/// </summary>
public class Health : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 100; // The maximum health of the object.
    private int currentHealth; // The current health of the object.

    /// <summary>
    /// This method is called once when the script instance is being loaded.
    /// It's used for initialization.
    /// </summary>
    void Start()
    {
        // Set the current health to the maximum health at the start of the game.
        currentHealth = maxHealth;
    }

    /// <summary>
    /// Reduces the object's health by a specified amount.
    /// </summary>
    /// <param name="amount">The amount of damage to take.</param>
    public void TakeDamage(int amount)
    {
        // Subtract the damage amount from the current health.
        currentHealth -= amount;

        // Ensure health doesn't go below zero.
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    /// <summary>
    /// Handles the "death" of the object when its health reaches zero.
    /// </summary>
    private void Die()
    {
        // For now, we'll just deactivate the game object.
        // In a real game, you might want to play a death animation, show a game over screen, etc.
        gameObject.SetActive(false);
    }
}
