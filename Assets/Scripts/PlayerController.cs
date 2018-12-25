using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;
	private Rigidbody rb;
	private int count;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
	}

	// FixedUpdate() is called before phyiscs calculations
	private void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			count++;
		}
	}
}
