using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObjectPoolerCD
{
    public class ObjectPoolerTemp : MonoBehaviour
    {
        public GameObject[] bulletsRevolver = new GameObject[7];

        public GameObject player;
        public GameObject bullet;
       
        public GameObject bulletRevolver;
        public SpriteRenderer bulletSprite;

        public bool placeholder;

        // Start is called before the first frame update
        void Start()
        {
            placeholder = false;
            GameObject bulletR0 = bulletsRevolver[0];
            GameObject bulletR1 = bulletsRevolver[1];
            GameObject bulletR2 = bulletsRevolver[2];
            GameObject bulletR3 = bulletsRevolver[3];
            GameObject bulletR4 = bulletsRevolver[4];
            GameObject bulletR5 = bulletsRevolver[5];
            GameObject bulletR6 = bulletsRevolver[6];
            GameObject bulletR7 = bulletsRevolver[7];

            
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
            //moves bullet to players position and rotation
            int shootBullet = BulletGet();
            if (shootBullet == 8)
            {
                shootBullet = 0;
                GameObject bulletR0 = bulletsRevolver[0];
                GameObject bulletR1 = bulletsRevolver[1];
                GameObject bulletR2 = bulletsRevolver[2];
                GameObject bulletR3 = bulletsRevolver[3];
                GameObject bulletR4 = bulletsRevolver[4];
                GameObject bulletR5 = bulletsRevolver[5];
                GameObject bulletR6 = bulletsRevolver[6];
                GameObject bulletR7 = bulletsRevolver[7];
            }
            bullet = bulletsRevolver[shootBullet];
            bullet.transform.position = player.transform.position;
            bullet.transform.rotation = player.transform.rotation;
            bullet.SetActive(true);
            // any other stuff you need to do with the bullet goes here
            bulletsRevolver[shootBullet] = null;
        }


        public int BulletGet()
        {
            int currentBullet = -1;
            for (int i = 0; i < 8; i++)
            {
                if (bulletsRevolver[i] != null)
                {
                    currentBullet = i;

                }
            }
            return currentBullet;
        }

      

        


    }
}

