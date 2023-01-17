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

        if (Mathf.Abs(verticalSpeed) > 75)
        {
            verticalSpeed = 0;
        }
        transform.Rotate(verticalSpeed, 0, 0);

        //if (transform.rotation.x < -75)
        //{
        //    transform.rotation = new Quaternion(-75, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        //}
        //else if (transform.rotation.x > 0)
        //{
        //    transform.rotation = new Quaternion(0, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        //}

        if (canBulletSpawn && Input.GetKey(KeyCode.Mouse1))
        {
            canBulletSpawn = false;
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.transform.rotation = new Quaternion(bullet.transform.rotation.x * -1, bullet.transform.rotation.y, bullet.transform.rotation.z, bullet.transform.rotation.z);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            Invoke(nameof(ResetBulletSpawn), shootTime);
        }
    }

    private void ResetBulletSpawn()
    {
        canBulletSpawn = true;
    }
}