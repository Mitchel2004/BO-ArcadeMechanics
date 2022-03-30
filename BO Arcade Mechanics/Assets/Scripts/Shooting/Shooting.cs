using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //
    public GameObject bullet;

    //bullet force
    public float shootForce, upwardForce;

    //Gun stats
    public float timeBetweenShooting, timeBetweenShots;
    public bool allowButtonHold;

    int bulletsShot;

    //bools
    bool shooting, readyToShoot, reloading;

    //Grafics
//    public GameObject lazerFlash;

    //Reference
    public Camera ShootCam;
    public Transform attackPoint;

    //debug
    bool allowInvoke = false;


    public void Awake()
    {
        readyToShoot = true;

    }
    public void Update() //run elke frame
    {
        PlayerInput();
    }
    private void PlayerInput()
    {
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.W);
        else shooting = Input.GetKeyDown(KeyCode.W);

        if (readyToShoot && shooting)
        {
            Shoot();
        }

    }
    private void Shoot()
    {
        readyToShoot = false;

        //Raycast
        Ray ray = this.ShootCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        //if raycast hit
        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75); //Shoot into the distance

        //Calulate direction frin attackPoint to targetPoint
        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;

        Vector3 directionWithSpread = directionWithoutSpread;
        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity);

        //Add forces to bullets
        currentBullet.GetComponent<Rigidbody>().AddForce(directionWithoutSpread.normalized * shootForce, ForceMode.Impulse);
        currentBullet.GetComponent<Rigidbody>().AddForce(ShootCam.transform.up * upwardForce, ForceMode.Impulse);

        //lazer Flash at the guns
//        if (lazerFlash != null)
//            Instantiate(lazerFlash, attackPoint.position, Quaternion.identity);

        
        Invoke("ResetShoot", timeBetweenShooting);
        //Resets shot

    }
    public void ResetShoot()
    {
        
        readyToShoot = true;
//        Invoke("Shoot", timeBetweenShooting);
    }
}


