/* By: Ryan Scheppler
 * Date: 10/11/19
 * Description: Add to fly enemy, handles fly specific death things
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDeath : MonoBehaviour
{
    public float DeathDelay = 1;
    Animator myAnimator;

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject);
    }
}
