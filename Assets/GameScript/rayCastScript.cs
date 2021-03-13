//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class rayCastScript : MonoBehaviour
//{

//    protected GameObject hitObject;
//    protected RaycastHit rayHit;

//    public GameObject reticle;



//    // Update is called once per frame
//    void Update()
//    {
//        LayerMask mask = LayerMask.GetMask("interactable" , "wayPoint");
//        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.green);
//        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out rayHit, 10.0f,mask))
//        {
           
//            if (hitObject == null)
//            {
//                RayExit();
//                hitObject = rayHit.transform.gameObject;
//                RayEnter(rayHit);
//            }
//        }
//        else
//        {
//            RayExit();
//        }

//    }
//    void RayExit()
//    {
//        reticle.GetComponent<reticle>().reticleScaleDown();
//        hitObject = null;
//        reticle.GetComponent<reticle>().normalColor();
//        StopAllCoroutines();
        
//    }


//void RayEnter(RaycastHit Hit)
//{
//        if (Hit.transform.gameObject.layer == LayerMask.NameToLayer("interactable"))


//        {
//            reticle.GetComponent<reticle>().reticleScaleUp();
//            //StartCoroutine(waypointTeleportation(Hit.transform));
//            Interactobject objscript = Hit.transform.gameObject.GetComponent<Interactobject>();
//            StartCoroutine(ObjectAction(objscript));
//        } else if (Hit.transform.gameObject.layer == LayerMask.NameToLayer("wayPoint"))

//        {
//            reticle.GetComponent<reticle>().reticleScaleUp();
//            StartCoroutine(waypointTeleportation(Hit.transform));
//        }
//}
//    IEnumerator ObjectAction(InteractObject obj)
//    {
//        yield return new WaitForSeconds(1);

//        //BoxCollider collider = gameObject.GetComponent<BoxCollider>));
//       // collider.enabled = false;
//        if (obj.ishidden)
//        {
//            //Debug.Log("test");
//            //Destroy(obj.gameObject);
//            //GameManager.itemsCollected++;

//        }
//        else
//        {
//            reticle.GetComponent<reticle>().highlightColor();
//        }

//    }
//    IEnumerator waypointTeleportation(Transform wayPointPosition)
//    {
//        //wait 1 second
//        yield return new WaitForSeconds(1);

//        Vector3 playerPosition;
//        playerPosition = wayPointPosition.position;
//        playerPosition.y = gameObject.transform.parent.transform.position.y;
//        gameObject.transform.parent.transform.position = playerPosition;
//    }
//}
