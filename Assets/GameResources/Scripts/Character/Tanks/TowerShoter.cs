using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TowerShoter
{
    private GameObject bulletPrefab;

    public void Shoot()
    {
        
    }
    //public List<Transform> turretBarrels;

    //public TurretData turretData;

    //private bool canShoot = true;
    //private Collider2D[] tankColliders;
    //private float currentDelay = 0;

    //private ObjectPool bulletPool;
    //[SerializeField]
    //private int bulletPoolCount = 10;

    //public UnityEvent OnShoot, OnCantShoot;
    //public UnityEvent<float> OnReloading;

    //private void Awake()
    //{
    //    tankColliders = GetComponentsInParent<Collider2D>();
    //    bulletPool = GetComponent<ObjectPool>();
    //}

    //private void Start()
    //{
    //    bulletPool.Initialize(turretData.bulletPrefab, bulletPoolCount);
    //    OnReloading?.Invoke(currentDelay);
    //}

    //private void Update()
    //{
    //    if (canShoot == false)
    //    {
    //        currentDelay -= Time.deltaTime;
    //        OnReloading?.Invoke(currentDelay);
    //        if (currentDelay <= 0)
    //        {
    //            canShoot = true;
    //        }
    //    }
    //}

    //public void Shoot()
    //{
    //    if (canShoot)
    //    {
    //        canShoot = false;
    //        currentDelay = turretData.reloadDelay;

    //        foreach (var barrel in turretBarrels)
    //        {
    //            //GameObject bullet = Instantiate(bulletPrefab);
    //            GameObject bullet = bulletPool.CreateObject();
    //            bullet.transform.position = barrel.position;
    //            bullet.transform.localRotation = barrel.rotation;
    //            bullet.GetComponent<Bullet>().Initialize(turretData.bulletData);

    //            foreach (var collider in tankColliders)
    //            {
    //                Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), collider);
    //            }

    //        }

    //        OnShoot?.Invoke();
    //        OnReloading?.Invoke(currentDelay);
    //    }
    //    else
    //    {
    //        OnCantShoot?.Invoke();
    //    }

    //}
}
