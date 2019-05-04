using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	//Initialize Variables
    GameObject getTarget;
    bool isMouseDragging;
    Vector3 offsetValue;
    Vector3 positionOfScreen;
	public Transform spawnPos;
	public Transform spawnPos1;
	public Transform spawnPos2;
	public Transform spawnPos3;
	public Transform spawnPos4;
	public Transform spawnPos5;
	public Transform spawnPos6;
	public Transform spawnPos7;
	public Transform spawnPos8;
	public float sphereRadius;

    // Use this for initialization
    void Start()
    {
		sphereRadius = 0.2f;
    }

    void Update()
    {

        //Mouse Button Press Down
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            getTarget = ReturnClickedObject(out hitInfo);
            if (getTarget != null)
            {
                isMouseDragging = true;
                //Converting world position to screen position.
                positionOfScreen = Camera.main.WorldToScreenPoint(getTarget.transform.position);
                offsetValue = getTarget.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionOfScreen.z));
            }
        }

        //Mouse Button Up
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDragging = false;
			RaycastHit hitInfo;
			getTarget = ReturnClickedObject(out hitInfo);
			if (getTarget != null) {
				
				if (hitInfo.transform.tag == "pasta") {
					if (Physics.CheckSphere (spawnPos.transform.position, sphereRadius)) {
						if (Physics.CheckSphere (spawnPos1.transform.position, sphereRadius)) {
							if (Physics.CheckSphere (spawnPos.transform.position, sphereRadius)) {
								Debug.Log ("mouseUp");
							} else {
								getTarget.transform.position = spawnPos.transform.position;
							}
						} else {
							getTarget.transform.position = spawnPos1.transform.position;
						}
					} else {
						getTarget.transform.position = spawnPos.transform.position;
					}
				}

				if (hitInfo.transform.tag == "pizza") {
					if (Physics.CheckSphere (spawnPos2.transform.position, sphereRadius)) {
						if (Physics.CheckSphere (spawnPos3.transform.position, sphereRadius)) {
							if (Physics.CheckSphere (spawnPos2.transform.position, sphereRadius)) {
								Debug.Log ("mouseUp");
							} else {
								getTarget.transform.position = spawnPos2.transform.position;
							}
						} else {
							getTarget.transform.position = spawnPos3.transform.position;
						}
					} else {
						getTarget.transform.position = spawnPos2.transform.position;
					}
				}

				if (hitInfo.transform.tag == "drink") {
					if (Physics.CheckSphere (spawnPos4.transform.position, sphereRadius)) {
						if (Physics.CheckSphere (spawnPos5.transform.position, sphereRadius)) {
							if (Physics.CheckSphere (spawnPos4.transform.position, sphereRadius)) {
								Debug.Log ("mouseUp");
							} else {
								getTarget.transform.position = spawnPos4.transform.position;
							}
						} else {
							getTarget.transform.position = spawnPos5.transform.position;
						}
					} else {
						getTarget.transform.position = spawnPos4.transform.position;
					}
				}

				if (hitInfo.transform.tag == "sauce") {
					if (Physics.CheckSphere (spawnPos6.transform.position, sphereRadius)) {
							
					} else {
						getTarget.transform.position = spawnPos6.transform.position;
					}
				}

				if (hitInfo.transform.tag == "sisig") {
					if (Physics.CheckSphere (spawnPos7.transform.position, sphereRadius)) {
						
					} else {
						getTarget.transform.position = spawnPos7.transform.position;
					}
				}

				if (hitInfo.transform.tag == "cheese") {
					if (Physics.CheckSphere (spawnPos8.transform.position, sphereRadius)) {
						
					} else {
						getTarget.transform.position = spawnPos8.transform.position;
					}
				}
			}
        }

        //Is mouse Moving
        if (isMouseDragging)
        {
            //tracking mouse position.
            Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionOfScreen.z);

            //converting screen position to world position with offset changes.
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offsetValue;

            //It will update target gameobject's current postion.
            getTarget.transform.position = currentPosition;
        }


    }

    //Method to Return Clicked Object
    GameObject ReturnClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray.origin, ray.direction * 10, out hit) && hit.transform.tag != "Undraggable")
        {
            target = hit.collider.gameObject;
        }
        return target;
    }
}
