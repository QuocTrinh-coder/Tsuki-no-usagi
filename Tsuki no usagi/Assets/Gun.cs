using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float rotationSpeed;
    public float bulletSpeed;
    public float shootTime;
    bool canBulletSpawn = true;

    // Update is called once per frame
    void Update()
    {
        // Rotate orientation
        //float horizontalSpeed = Input.GetAxis("Mouse X") * rotationSpeed;
        float verticalSpeed = Input.GetAxis("Mouse Y") * -rotationSpeed;
        transform.Rotate(verticalSpeed, 0, 0);

        if (transform.position.y < -75)
        {
            transform.position = new Vector3(transform.position.x, -75, transform.position.z);
        }
        else if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

        if (canBulletSpawn && Input.GetKey(KeyCode.Mouse1))
        {
            canBulletSpawn = false;
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            Invoke(nameof(ResetBulletSpawn), shootTime);
        }
    }

    private void ResetBulletSpawn()
    {
        canBulletSpawn = true;
    }
}