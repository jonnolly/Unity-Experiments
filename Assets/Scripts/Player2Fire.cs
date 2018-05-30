using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player2Fire : MonoBehaviour {
	// todo:
	//	*	Combine Player1Fire & Player2Fire into one PlayerFire class with exposed fields: KeyCode FireKey & int initialXDirection

    public GameObject BulletPrefab;
    private float _projectileVelocity = 3;
    private List<GameObject> _projectiles = new List<GameObject>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
			GameObject bullet = (GameObject)Instantiate(BulletPrefab, transform.position, Quaternion.identity);
			var colliderScript = bullet.GetComponent<ColliderScript> ();
			colliderScript.ParentPlayer = gameObject;
            _projectiles.Add(bullet);
            for (int i = 0; i < _projectiles.Count; i++)
            {
                var currentBullet = _projectiles[i];
                currentBullet.transform.Translate(new Vector3(-1, 0) * Time.deltaTime * _projectileVelocity);
                var bulletPos = Camera.main.WorldToScreenPoint(currentBullet.transform.position);
                if (bulletPos.x < 0 || bulletPos.x > Screen.width || bulletPos.y < 0 || bulletPos.y > Screen.height)
                {
                    DestroyObject(currentBullet);
                    _projectiles.Remove(currentBullet);
                }
            }
        }
    }
}
