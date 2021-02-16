using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial3 : MonoBehaviour
{
    public Material[] material;
   Renderer rend;
     public GameObject sceneComplete;
 // Start is called before the first frame update
    void Start()
    {
      rend = GetComponent<Renderer>();
      rend.enabled = true;
      rend.sharedMaterial = material[0];  
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision col)
    {
       if (col.gameObject.tag == "Sphere")
         StartCoroutine(TimeDelay());
    {
       rend.sharedMaterial = material[1];
    }
        IEnumerator TimeDelay()
       {
        yield return new WaitForSeconds(3f);
        sceneComplete.SetActive(true);
       }
       
  } 
}
