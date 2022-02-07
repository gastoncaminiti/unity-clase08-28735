using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 2f;

    [SerializeField] GameObject bulletPrefab;

    [SerializeField] GameObject shootPoint;

    [SerializeField] float cooldown = 2f;


     [SerializeField] private bool canShoot = true;

     [SerializeField] private float timePass = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //SI APRIETO W
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //SI APRIETO S
            MovePlayer(Vector3.left);
        }
        //SI APRIETO A
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.forward);
        }
        //SI APRIETO D
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.back);
        }

        //SI APRIETO E
        if (Input.GetKeyDown(KeyCode.E) && canShoot)
        {
            //
            Instantiate(bulletPrefab, shootPoint.transform.position, bulletPrefab.transform.rotation);// PROYECTILES
            Instantiate(bulletPrefab, shootPoint.transform.position + Vector3.forward, bulletPrefab.transform.rotation);// PROYECTILES\
             Instantiate(bulletPrefab, shootPoint.transform.position + Vector3.back, bulletPrefab.transform.rotation);// PROYECTILES
            
            canShoot = false;
        }


        if(!canShoot){
            //timePass = timePass + Time.deltaTime;
            timePass += Time.deltaTime;
        } // !canShoot  !false == true

        if(timePass > cooldown){
            timePass = 0;
            canShoot = true;
        }

    }

    private void MovePlayer(Vector3 directionEnemy)
    {
        transform.Translate(speed * Time.deltaTime * directionEnemy);
    }
}
