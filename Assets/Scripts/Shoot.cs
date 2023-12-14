using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform spawnPoint;
    public float shootForce = 10f;
    public float minTimeBetweenShots = 2f;
    public float maxTimeBetweenShots = 5f;

    private float timeBetweenShots;
    private float timeSinceLastShot;

    void Start()
    {
        // Initialize the time between shots with a random value between min and max
        timeBetweenShots = Random.Range(minTimeBetweenShots, maxTimeBetweenShots);
    }

    void Update()
    {
        // Update the time since the last shot
        timeSinceLastShot += Time.deltaTime;

        // Check if enough time has passed to shoot again
        if (timeSinceLastShot >= timeBetweenShots)
        {
            Fire();

            // Reset the timer
            timeSinceLastShot = 0f;

            // Randomize the time between shots for the next shot
            timeBetweenShots = Random.Range(minTimeBetweenShots, maxTimeBetweenShots);
        }
    }

    void Fire()
    {
        GameObject projectile = Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        if (projectileRb != null)
        {
            projectileRb.AddForce(spawnPoint.forward * shootForce, ForceMode.Impulse);
        }
    }
}
