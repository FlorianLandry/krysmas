using UnityEngine;

namespace BrokenVector.LowPolyFencePack
{
    /// <summary>
    /// This class toggles the door animation.
    /// The gameobject of this script has to have the DoorController script which needs an Animator component
    /// and some kind of Collider which detects your mouse click applied.
    /// </summary>
    
    [RequireComponent(typeof(DoorController))]
	public class DoorToggle : MonoBehaviour
    {
        public Camera cam;
        private DoorController doorController;
        public Collider[] colliders;
        public bool isOpened;

        void Awake()
        {
            doorController = GetComponent<DoorController>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 50))
                {
                    if (hit.transform.gameObject.GetComponent<Animation>().enabled)
                    {
                        if (isOpened)
                        {
                            colliders[3].enabled = false;
                            colliders[2].enabled = true;
                            isOpened = !isOpened;
                        }
                        else
                        {
                            colliders[2].enabled = false;
                            colliders[3].enabled = true;
                            isOpened = !isOpened;
                        }
                        open();
                    }
                }
            }
        }

        void open()
	    {
            //if(Vector3.Distance(transform.position, cam.transform.position) <= 10)
            {
                doorController.ToggleDoor();
            }
	        
	    }

	}
}