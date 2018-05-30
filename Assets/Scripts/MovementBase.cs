using UnityEngine;
using System.Collections;
using System;

public class MovementBase : MonoBehaviour {

    private float _speed = 1;
    protected float translationX;
    protected float translationY;
    public string SprintKey;
    private KeyCode _sprintKey;

    // Use this for initialization
    void Start()
    {
		Console.WriteLine("Test");// todo: Remove

        _sprintKey = (KeyCode)Enum.Parse(_sprintKey.GetType(), SprintKey);
    }

    void Update()
    {
        if (Input.GetKey(_sprintKey))
        {
            _speed = 2;
        }
        else
        {
            _speed = 1;
        }

        RetrieveAxes();
    }

    protected virtual void RetrieveAxes()
    {
        MovePlayer();
    }

    protected void MovePlayer()
    {
        transform.Translate(_speed * translationX, _speed * translationY, 0);
        transform.Translate(_speed * translationX, _speed * translationY, 0);
    }
}
