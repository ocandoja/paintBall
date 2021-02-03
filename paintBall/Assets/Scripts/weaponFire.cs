using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponFire : MonoBehaviour
{
    public float damageAmount = 1f;
    public float range = 150;
    public Camera pCamera;
    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
       {
           Shoot();
       } 
    }
    void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(pCamera.transform.position, pCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.damageReceived(damageAmount);
            }
        }
    }
}
