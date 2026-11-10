using System;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.Rendering;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Boolean chasing;
    private Transform player;


    private void Update() {
        if (chasing) {
            float step = _speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, player.position, step);
        }
    
    }

    public void StopChase(Transform _playerPosition) {
        chasing = false;
    }

    public void StartChase(Transform _playerPosition) {
        player = _playerPosition;
        chasing = true;
    }
}
