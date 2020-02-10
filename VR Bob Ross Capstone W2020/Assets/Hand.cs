using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Hand : MonoBehaviour
{
	// Unity Settings
	public enum HandCode { Left, Right };
	public HandCode HandType = HandCode.Left;
	public bool UnparentFromVRController = false;

	// VR Controls
	bool isTriggerHeld = false;

	// VR Settings
	XRNode HandNode;

    public bool Mouse1;
    public bool Mouse2;
    public bool Mouse3;

    void Start()
	{
		if (HandType == HandCode.Left)
		{
			HandNode = XRNode.LeftHand;
		}
		else
		{
			HandNode = XRNode.RightHand;
		}
	}

	void Update()
	{
		if (!UnparentFromVRController)
		{
			return;
		}

		TriggerUpdate();
		TransformUpdate();
	}

	void TriggerUpdate()
	{
		isTriggerHeld = Input.GetAxisRaw(HandType == HandCode.Left
			? "Left Trigger" : "Right Trigger") > 0.3f;

		if (isTriggerHeld)
		{
            //...
            Mouse1 = true;
		}
		else
		{
            //...
            Mouse1 = false;
        }
    }

	void TransformUpdate()
	{
		var states = new List<XRNodeState>();
		InputTracking.GetNodeStates(states);

		foreach (var state in states)
		{
			if (state.nodeType == HandNode)
			{
				Vector3 pos;
				if (state.TryGetPosition(out pos))
					transform.position = pos;

				Quaternion rot;
				if (state.TryGetRotation(out rot))
					transform.rotation = rot;

				return;
			}
		}
	}
}