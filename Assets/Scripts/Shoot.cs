using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public ParticleSystem particles;
    public ParticleSystem collisionExplosionPrefab;

    private void Update(){
        if(Input.GetMouseButtonDown(0)){
                particles.Play();
                if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo)){
                    ParticleSystem collisionExplosion = Instantiate(collisionExplosionPrefab, hitInfo.point, Quaternion.identity);
                    collisionExplosion.transform.LookAt(hitInfo.normal);
                    Debug.Log(hitInfo.collider.name);
                    Destroy(hitInfo.collider.gameObject);
            }
        }
    }
}
