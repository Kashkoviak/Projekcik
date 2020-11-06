using UnityEngine;
using System.Collections;

public class RoguelikePlayerController : MonoBehaviour
{
	public float walkSpeed = 2;
	public GameObject ammoUp;
	public GameObject ammoDown;
	public GameObject ammoLeft;
	public GameObject ammoRight;


	void FixedUpdate()
	{
		Movement();
		Attack();
	}

	void Movement()
	{



		//w górę, skok
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector2.up * walkSpeed * Time.deltaTime);
		}


		//brak funkcji
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector2.down * walkSpeed * Time.deltaTime);
		}

		//w lewo
		if (Input.GetKey(KeyCode.A))
		{

			transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);

			if (transform.localScale.x > 0)
				transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
		}

		//w prawo
		if (Input.GetKey(KeyCode.D))
		{

			transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);

			if (transform.localScale.x < 0)
				transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

		}



	}

	void Attack()
	{

		//strzał w górę
		if (Input.GetKey(KeyCode.UpArrow))
		{
			GameObject.Instantiate(ammoUp, new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), transform.localRotation);
		}


		//strzał w dół
		if (Input.GetKey(KeyCode.DownArrow))
		{
			GameObject.Instantiate(ammoDown, new Vector3(transform.position.x, transform.position.y - 0.60f, transform.position.z), transform.localRotation);

		}


		//strzał w lewo
		if (Input.GetKey(KeyCode.LeftArrow))
		{

			GameObject.Instantiate(ammoLeft, new Vector3(transform.position.x - 0.80f, transform.position.y, transform.position.z), transform.localRotation);

		}


		//strzał w prawo
		if (Input.GetKey(KeyCode.RightArrow))
		{

			GameObject.Instantiate(ammoRight, new Vector3(transform.position.x + 0.80f, transform.position.y, transform.position.z), transform.localRotation);

		}
	}
}