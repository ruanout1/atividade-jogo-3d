using UnityEngine;

public enum enemyState
{
    IDLE, ALERT, EXPLORE,
    PATROL, FOLLOW, FURY
}

public class GameManager : MonoBehaviour
{
    public Transform player;
    [Header("Slime IA")]
    public Transform[] slimeWayPoints;
    public float slimeDistanceToAttack = 2.3f;
    public float slimeAlertTime = 2f;
    public float slimeAttackDelay = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
