using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Crocodile : Enemy, IShootable
{

    [SerializeField] private float attackRange;
    [SerializeField] public Player player;


    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    void Start()
    {
        Init(30);
        BulletTimer = 0.0f;
        BulletSpawnTime = 2.0f;
        DamageHit = 30;
        player = GameObject.FindObjectOfType<Player>();

    }
    
    private void Update()
    {

        BulletTimer += Time.deltaTime;

        Behavior();
    }
    public override void Behavior()
    {
        Vector2 direction = player.transform.position - transform.position;
        
    
        if (direction.magnitude <= attackRange )
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        if (BulletTimer >= BulletSpawnTime)
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Rock rock = obj.gameObject.GetComponent<Rock>();
            rock.Init(20, this);

            BulletTimer = 0;
        }
        

         //Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
        // BulletTimer = BulletSpawnTime; 
    }

}
