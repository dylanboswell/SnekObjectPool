using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObjectPoolerCD
{
    public class ObjectPoolerTemp : MonoBehaviour
    {
        public Transform[] bulletsRevolver = new Transform[7];

        public GameObject player;
        public GameObject bullet;
       
        public GameObject bulletRevolver;
        public SpriteRenderer bulletSprite;

        // Start is called before the first frame update
        void Start()
        {
            Transform bulletR0 = bulletsRevolver[0];
            Transform bulletR1 = bulletsRevolver[1];
            Transform bulletR2 = bulletsRevolver[2];
            Transform bulletR3 = bulletsRevolver[3];
            Transform bulletR4 = bulletsRevolver[4];
            Transform bulletR5 = bulletsRevolver[5];
            Transform bulletR6 = bulletsRevolver[6];
            Transform bulletR7 = bulletsRevolver[7];

            
        }

        // Update is called once per frame
        void Update()
        {

        }



        public void OnTriggerEnter(Collider other)
        {

        }

        public void ShootBullet()
        {
            bullet.transform.position = player.transform.position;
            bullet.transform.rotation = player.transform.rotation;
            

        }

        /*public void BulletGet()
        {
            for (int i = 0; i < 8; i++)
            {
                return bulletsRevolver[i];
            }
            GameObject bullet = GameObject.Instantiate(bulletRevolver, new Vector3(1, 1, 0), Quaternion.identity);
        }
        */

    public void Reload()
        {


        }
    }
}

