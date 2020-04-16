// Arduino connection source code: https://gist.github.com/automatedChaos/dccc7a90d32e318be6fa6dc04ff69806

using UnityEngine;

using System.IO.Ports;
using System;

public class Turret : MonoBehaviour
{
    public GameObject bullet;
    public float turretRotationSpeed = 1.0f;

    public enum TurretActions 
    {
        RotateLeft,
        RotateRight,
        Fire
    };

    [Header("Arduino")]
    public int commPort = 0;
    private SerialPort serial = null;
    private bool connected = false;

    void Start()
    {
        ConnectToSerial();
    }

    void ConnectToSerial()
    {
        Debug.Log("Attempting Serial: " + commPort);

        serial = new SerialPort("\\\\.\\COM" + commPort, 9600);
        serial.ReadTimeout = 50;
        serial.Open();
    }

    void Update()
    {
        string value = ReadFromArduino(50);
        int intValue;

        if (value != null)
        {
            if (Int32.TryParse(value, out intValue))
            {
                ExecuteTurretCommand(intValue);
            }
            else
            {
                Debug.LogAssertion("Arduino input was not an int");
            }
        }
    }

    public string ReadFromArduino(int timeout = 0)
    {
        serial.ReadTimeout = timeout;
        try
        {
            return serial.ReadLine();
        }
        catch (TimeoutException e)
        {
            return null;
        }
    }

    void ExecuteTurretCommand(int command)
    {
        switch (command)
        {
            case (int)TurretActions.RotateLeft:
                RotateTurret(true);
                break;
            case (int)TurretActions.RotateRight:
                RotateTurret(false);
                break;
            case (int)TurretActions.Fire:
                FireTurret(Bullet.EnemyType.Kill);
                break;
            default:
                Debug.LogAssertion("Unrecognized command received from arduino");
                break;
        }
    }

    void FireTurret(Bullet.EnemyType bulletType)
    {
        GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody2D>().velocity = 10 * transform.up;
        newBullet.GetComponent<Bullet>().type = bulletType;
    }

    void RotateTurret(bool rotateLeft)
    {
        if (rotateLeft)
        {
            transform.Rotate(0.0f, 0.0f, turretRotationSpeed);
        }
        else
        {
            transform.Rotate(0.0f, 0.0f, -turretRotationSpeed);
        }
    }
}
