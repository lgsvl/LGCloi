/**
 * Copyright (c) 2021 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE-SVLSimulator.
 *
*/

using UnityEngine;
using Simulator.Utilities;

public class DifferentialDriveSMI : MonoBehaviour, IVehicleDynamics
{
    private ArticulationBody AB;
    public Vector3 Velocity => AB.velocity;
    public Vector3 AngularVelocity => AB.angularVelocity;
    public Transform BaseLink { get { return BaseLinkTransform; } }
    public Transform BaseLinkTransform;
    public float AccellInput => RobotController.AccelInput;
    public float SteerInput  => RobotController.SteerInput;
    public bool HandBrake { get; set; } = false;
    public float CurrentRPM { get; set; } = 0f;
    public float CurrentGear { get; set; } = 1f;
    public bool Reverse { get; set; } = false;
    public float WheelAngle { get; set; } = 0f;
    public float Speed { get; set; } = 0f;

    public float MaxSteeringAngle { get; set; } = 0f;
    public IgnitionStatus CurrentIgnitionStatus { get; set; } = IgnitionStatus.On;

    private RobotController RobotController;

    private void Awake()
    {
        AB = GetComponent<ArticulationBody>();
        RobotController = GetComponentInParent<RobotController>();
    }

    public bool ForceReset(Vector3 pos, Quaternion rot)
    {
        AB.TeleportRoot(pos, rot);
        return true;
    }

    public bool GearboxShiftDown()
    {
        return false;
    }

    public bool GearboxShiftUp()
    {
        return false;
    }

    public bool SetHandBrake(bool state)
    {
        return false;
    }

    public bool ShiftFirstGear()
    {
        return false;
    }

    public bool ShiftReverse()
    {
        return false;
    }

    public bool ShiftReverseAutoGearBox()
    {
        return false;
    }

    public bool ToggleHandBrake()
    {
        return false;
    }

    public bool ToggleIgnition()
    {
        return false;
    }

    public bool ToggleReverse()
    {
        return false;
    }
}
