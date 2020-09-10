using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetDistance : MonoBehaviour
{
    public TextMeshPro dist;
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball") { 
            float distFromMe = Vector3.Distance(Vector3.zero, col.GetContact(0).point);
            dist.text = "Dist: " + distFromMe.ToString("#.00");
        }
    }

}
