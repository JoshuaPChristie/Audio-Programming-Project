using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSoundTrigger : MonoBehaviour
{
	/// The Wwise Event to trigger when the box is picked up and dropped (use a SequenceContainer).
	public AK.Wwise.Event pickupAndDropSound = new AK.Wwise.Event();
	/// The Wwise Event to trigger when the box collides with the ground.
	public AK.Wwise.Event groundCollideSound = new AK.Wwise.Event();

	/// Used to trigger a sound when the box collides with something after falling.
	private bool falling = false;

	///	Called when the box is picked up.
	public void PickupBox()
	{
		pickupAndDropSound.Post(gameObject);
	}

	///	Called when the box is picked up.
	public void DropBox()
	{
		pickupAndDropSound.Post(gameObject);
	}

	///	We use this to trigger a sound when the box collides with the ground.
	public void OnCollisionEnter(Collision collision)
	{
		if(falling)
		{
			groundCollideSound.Post(gameObject);
		}
	}

	/// Used to set our falling variable.
	void OnCollisionStay(Collision collision)
	{
		falling = false;
	}

	/// Used to set our falling variable.
	void OnCollisionExit(Collision collision)
	{
		falling = true;
	}
}
