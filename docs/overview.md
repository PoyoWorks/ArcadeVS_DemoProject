---
layout: default
title: Technical Specification
nav_order: 10
---

# Technical Specification

- Supported Development Platforms: Windows
- Supported Target Build Platforms: x64 / Android / HTML5
- Network Replicated: No, this feature is under development. There a networked player controller available but the movement on the owning client is jaggy.

## Full content

### Code

5 C++ classes 
- Module
- Vehicle System 
- Visualizer 
- Base Player Controller
- Base Animation Instance

### Assets

7 Blueprint classes
- Sports Vehicle
- Kart Vehicle
- Light Kart Vehicle
- Heavy Kart Vehicle
- Template Vehicle
- Test Vehicle
- Networked Player Controller (work in progress)
- Player Controller
- Default Vehicle Anim
- Drift Vehicle Anim

6 Materials

3 Models 
- Kart Skeletal Mesh. Fully textured with physics asset, iddle animation and blueprint animation logic
- Sports Vehicle Skeletal Mesh.
- Test Vehicle Skeletal Mesh with physics asset

5 VFXs
- Kart Vehicle drift/exhaust/smoke/sparkes and boost effects

## Features

- Full Vehicle System logic in C++ for high performances
- RayCast Suspension system with suspension length, suspension points, damping and adherence tuning
- Acceleration, braking and reverse, turning
- Customizable drifting mechanic
- Jumping!
- In air stabilization setting allows for either relastic vehicle roll overs or arcade like super stabibility
- Center of mass offset, adherence force offset and many other nice parameters
- All functions can be overriden in C++ so that you can get the exact behavior you want
- All state values and forces exposed to Blueprints
- Blueprint events for all state changes! Accelerate Start/Stop, Can Drift, Drift Start/Stop etc...
- Blueprint Animation system for wheels rotation, wheels suspension offsets, direction, drift, tilt and roll.
- Demo vehicles included. Properly tuned and game ready. Simply update your mesh and animations and play.



